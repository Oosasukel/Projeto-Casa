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
            //Aqui ta pegando só o primeiro item, arrumar isso
            let itemPedido = response.carrinhoViewModel.itens.find(item => item.pedidoId == response.carrinhoViewModel.pedidoId);
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']');
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[subtotal]').html((itemPedido.quantidade * itemPedido.precoUnidade).duasCasas());

            var total = 0;
            response.carrinhoViewModel.itens.forEach(item => {
                total += item.precoUnidade * item.quantidade;
            });

            linhaDoItem.parents('table').next('[total]').html((total).duasCasas());
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