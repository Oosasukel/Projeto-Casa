using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Repositories;

namespace ProjetoCasaDeShow
{
    public interface IDataService
    {
        IEventoRepository GetEventoRepository();
        ICasaDeShowRepository GetCasaDeShowRepository();
        IItemPedidoRepository GetItemPedidoRepository();
        IPedidoRepository GetPedidoRepository();
        IHistoricoRepository GetHistoricoRepository();
        string SalvaImagem(IFormFile arquivo, string pastaDentroDaRoot, string nome);
        AppContext GetContexto();
        void SalvaCaminhoNoEvento(int eventoId, string pathImage);
        void SalvaCaminhoNaCasa(int casaId, string pathImage);
    }

    public class DataService : IDataService
    {
        private IEventoRepository eventoRepository;
        private ICasaDeShowRepository casaDeShowRepository;
        private IPedidoRepository pedidoRepository;
        private IItemPedidoRepository itemPedidoRepository;
        private IHistoricoRepository historicoRepository;
        IWebHostEnvironment _webHostEnvironment;

        private AppContext contexto;

        public DataService(IEventoRepository eventoRepository,
                            ICasaDeShowRepository casaDeShowRepository,
                            IPedidoRepository pedidoRepository,
                            IItemPedidoRepository itemPedidoRepository,
                            IHistoricoRepository historicoRepository,
                            IWebHostEnvironment env,
                            AppContext contexto)
        {
            this.eventoRepository = eventoRepository;
            this.casaDeShowRepository = casaDeShowRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
            this.historicoRepository = historicoRepository;
            _webHostEnvironment = env;

            this.contexto = contexto;
        }

        public ICasaDeShowRepository GetCasaDeShowRepository()
        {
            return casaDeShowRepository;
        }

        public AppContext GetContexto()
        {
            return contexto;
        }

        public IEventoRepository GetEventoRepository()
        {
            return eventoRepository;
        }

        public IHistoricoRepository GetHistoricoRepository()
        {
            return historicoRepository;
        }

        public IItemPedidoRepository GetItemPedidoRepository()
        {
            return itemPedidoRepository;
        }

        public IPedidoRepository GetPedidoRepository()
        {
            return pedidoRepository;
        }

        public void SalvaCaminhoNaCasa(int casaId, string pathImage)
        {
            var casa = casaDeShowRepository.GetCasaPeloId(casaId);
            casa.PathImage = pathImage;
            contexto.SaveChanges();
        }

        public void SalvaCaminhoNoEvento(int eventoId, string pathImage)
        {
            var evento = eventoRepository.GetEventoPeloId(eventoId);
            evento.PathImage = pathImage;
            contexto.SaveChanges();
        }

        //Retorna imagePath ou null se arquivo for invalido
        //formato da string pastaDentroDaRoot: @"\Arquivos\Images\Testes\"
        public string SalvaImagem(IFormFile arquivo, string pastaDentroDaRoot, string nome)
        {
            //verifica se existe arquivo
            if (arquivo != null && arquivo.Length > 0)
            {
                //Obtem extensão do arquivo
                var partesArquivo = arquivo.FileName.Split('.');
                var extensao = "." + partesArquivo[partesArquivo.Count() - 1];

                //Verifica se extensão é permitida
                if(extensao == ".jpg" || extensao == ".gif" || extensao == ".png"){
                    var nomeArquivo = nome + extensao;


                    // monta o caminho onde vamos salvar o arquivo : 
                    // ~\wwwroot\Arquivos\Images\Testes
                    string caminhoDestinoArquivo = _webHostEnvironment.WebRootPath + pastaDentroDaRoot;

                    //Cria o diretório se não existir
                    if (!Directory.Exists(caminhoDestinoArquivo))
                    {
                        Directory.CreateDirectory(caminhoDestinoArquivo);
                    }

                    // incluir a pasta Recebidos e o nome do arquivo enviado : 
                    // ~\wwwroot\Arquivos\Images\Testes
                    string caminhoDestinoArquivoOriginal = caminhoDestinoArquivo + nomeArquivo;

                    string caminhoSemExtensao = caminhoDestinoArquivo + nome;
                    if(File.Exists(caminhoSemExtensao + ".jpg")){
                        File.Delete(caminhoSemExtensao + ".jpg");
                    }
                    if(File.Exists(caminhoSemExtensao + ".gif")){
                        File.Delete(caminhoSemExtensao + ".gif");
                    }
                    if(File.Exists(caminhoSemExtensao + ".png")){
                        File.Delete(caminhoSemExtensao + ".png");
                    }
                    

                    //copia o arquivo para o local de destino original
                    using (var stream = new FileStream(caminhoDestinoArquivoOriginal, FileMode.Create))
                    {
                        arquivo.CopyTo(stream);
                    }
                    string pathImageHtml = pastaDentroDaRoot + nomeArquivo;
                    pathImageHtml = pathImageHtml.Replace('\\','/');
                    return pathImageHtml;
                }

                return null;
            }

            return null;
        }
    }
}