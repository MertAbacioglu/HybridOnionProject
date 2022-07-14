
//ilgili ürünün özelliklerini getiren ve modal içine basan fonksiyon
function GetProductFeature(id) {
    $.get("ProductFeatures/GetById/" + id)
        .done(function (data) {
            console.log(data);
            $('.modal-body').html(`
            <p>Color : ${data.color}</p>
            <p>Height: ${data.height}</p>
            <p>Width : ${data.width}</p>
            `);
        });
}
