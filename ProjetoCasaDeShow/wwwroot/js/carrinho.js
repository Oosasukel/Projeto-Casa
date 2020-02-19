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
    
    enviaPost(informacao){
        var test = JSON.stringify(informacao);
        
        $.ajax({
            url: '/Pedido/updateQuantidade',
            type: 'Post',
            contentType: 'application/json',
            data: JSON.stringify(informacao)
        }).done(function(response){
            location.reload();
        });
    }
    
    getData(elemento){
        var linhaItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaItem).attr('item-id');
        var novaQtd = $(linhaItem).find('[item-qtd]').val();
        
        return {
            Id: Number(itemId),
            Quantidade: novaQtd
        };
    }
}

var carrinho = new Carrinho();

