

//ilgili ürünün özelliklerini getiren ve modal içine basan fonksiyon 
function GetProductFeature(id) {
    $.get("ProductFeatures/GetById/" + id)
        .done(function (data) {
            console.log(data);
            $('.modal-body').html(`
            <p>${data.color}</p>
            <p>${data.height}</p>
            <p>${data.width}</p>
            `);
        });
}
