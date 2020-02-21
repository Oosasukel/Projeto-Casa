class Carrinho {
    clickMenos(btn) {
        var item = this.getData(btn);
        item.Quantidade--;
        this.enviaPost(item);

    }

    clickMais(btn) {
        var item = this.getData(btn);
        item.Quantidade++;
        this.enviaPost(item);
    }

    updateQuantidade(input) {
        var item = this.getData(input);
        this.enviaPost(item);
    }

    enviaPost(informacao) {
        var test = JSON.stringify(informacao);

        $.ajax({
            url: '/Pedido/updateQuantidade',
            type: 'Post',
            contentType: 'application/json',
            data: JSON.stringify(informacao)
        }).done(function(response) {
            var total = 0;
            response.carrinhoViewModel.itens.forEach(item => {
                let itemPedido = response.carrinhoViewModel.itens.find(i => i.id == item.id);
                let linhaDoItem = $('[item-id=' + item.id + ']');
                linhaDoItem.find('input').val(itemPedido.quantidade);
                linhaDoItem.find('[subtotal]').html((itemPedido.quantidade * itemPedido.precoUnidade).duasCasas());
                total += item.precoUnidade * item.quantidade;
            });

            $('table').next('[total]').html('Total: ' + (total).duasCasas());
        });
    }

    getData(elemento) {
        var linhaItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaItem).attr('item-id');
        var novaQtd = Number($(linhaItem).find('[item-qtd]').val());

        return {
            Id: Number(itemId),
            Quantidade: novaQtd
        };
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function() {
    return this.toFixed(2).replace('.', ',');
}