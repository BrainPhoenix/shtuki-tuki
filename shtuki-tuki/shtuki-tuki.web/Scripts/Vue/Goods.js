var section = new Vue({
    data: {
        sectionGoodsList: true,
        sectionGoodsCreate: false,
        sectionGoodsEdit: false
    }
});

var vmFormCreateGood = new Vue({
    data: {
        categories: null,
        categoriesSelected: 0,
        name: '',
        descript: '',
        size: '',
        material: '',
        price: 0,
        message: ''
    },
    created: function () {
        $.ajax({
            type: 'GET',
            url: '/api/WebCategory',
            success: function (response) {
                console.log(response);
                vmFormCreateGood.categories = response;
            },
            error: function (xhr) {
                console.log(xhr.status);
            }
        });
    }
});

var vmGoodsFunction = new Vue({
    el: '.vue-admin-goods',
    methods: {
        GoodsListNav: function (message) {
            alert(message);
        },
        ViewCreateGood: function () {
            section.sectionGoodsList = false;
            section.sectionGoodsCreate = true;
            section.sectionGoodsEdit = false;
        },
        CloseCreateGood: function () {
            section.sectionGoodsCreate = false;
            section.sectionGoodsList = true;
        },
        SaveCreateGood: function () {
            console.log(vmFormCreateGood);

            var formData = new FormData();
            formData.append("categoryId", vmFormCreateGood.categoriesSelected);
            formData.append("name", vmFormCreateGood.name);
            formData.append("descript", vmFormCreateGood.descript);
            formData.append("material", vmFormCreateGood.material);
            formData.append("size", vmFormCreateGood.size);
            formData.append("price", vmFormCreateGood.price);

            var formDataPhoto = new FormData();
            var fileUpload = $("#goodAvatarCreate").get(0);
            var files = fileUpload.files;

            for (var i = 0; i < files.length; i++) {
                formDataPhoto.append(files[i].name, files[i]);
            }

            $.ajax({
                type: 'POST',
                url: '/api/WebGoods',
                data: formData,
                success: function (response) {
                    console.log(response);
                    if (response > 0) {
                        alert(response);
                        //$.ajax({
                        //    type: 'POST',
                        //    url: '/Admin/GoodAvatarUpload',
                        //    data: formData,
                        //    success: function (response) {
                        //        console.log(response);
                        //        if (response === "Good create") {

                        //        }
                        //    },
                        //    error: function (xhr) {
                        //        console.log(xhr.status);
                        //    }
                        //});
                    }
                },
                error: function (xhr) {
                    console.log(xhr.status);
                }
            });
        }
    }
});