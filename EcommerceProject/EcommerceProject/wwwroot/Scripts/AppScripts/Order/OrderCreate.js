var count = 0;

$("#addButton").click(function () {
    var productId = $("#productId").val();
    var productName = $("#productId option:selected").text();
    var qty = $("#qty").val();
    var unitPrice = $("#unitPrice").val();
    var discountPrice = $("#discount").val();

    var tr = '<tr>';
    var productTd = '<td> <input type="hidden" name="OrderDetails['+count+'].ProductId" value="'+productId+'"/>' + productName + ' </td>';
    var qtyTd = '<td> <input type="hidden" name="OrderDetails[' + count + '].ProductId" value="' + qty+'"/>' + qty + ' </td>';
    var unitPriceTd = '<td> <input type="hidden" name="OrderDetails[' + count + '].ProductId" value="' + unitPrice+'"/>' + unitPrice + ' </td>';
    var discountTd = '<td> <input type="hidden" name="OrderDetails[' + count + '].ProductId" value="' + discountPrice+'"/>' + discountPrice + ' </td>';

    tr += productTd + qtyTd + unitPriceTd + discountTd + "</tr>";
    $("#tbOrderDetails").append(tr);
    count++;
});