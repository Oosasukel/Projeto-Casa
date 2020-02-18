class Carrinho{
    clickMenos(btn){
        var item = this.getData(btn);
        item.Quantidade--;
        this.enviaPost(item);

    }
    
    clickMais(btn){
        var item = this.getData(btn);
        item.Quantidade++;
        this.enviaPost(item);
    }

    updateQuantidade(input){
        var item = this.getData(input);
        this.enviaPost(item);
    }
    
    enviaPost(data){
        $.ajax({
            url: '/Pedido/updateQuantidade',
            type: 'GET',
            contentType: 'application/json',
            data: data
        }).done(function(response){
            location.reload();
        });
    }
    
    getData(elemento){
        var linhaItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaItem).attr('item-id');
        var novaQtd = $(linhaItem).find('[item-qtd]').val();
    
        return {
            Id: itemId,
            Quantidade: novaQtd
        };
    }
}

var carrinho = new Carrinho();

