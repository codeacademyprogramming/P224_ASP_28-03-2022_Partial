$(function () {
    let skip = 6;
    let url = $(".load").attr("href");
    let trainercount = $("#trainercount").val();
    $(document).on("click", ".load", function (e) {
        e.preventDefault();

        fetch(url + '?skip=' + skip).then(response => {
            return response.text();
        }).then(data => {
            $(".trainerrow").append(data);
        })

        skip += 6;
        if (skip >= trainercount) {
            $(".load").remove();
        }

        //$.ajax({
        //    url: url + '?skip=' + skip,
        //    method: "GET",
        //    dataType: "html",
        //    success: function (response) {

        //        $(".trainerrow").append(response);
        //        skip += 6;
        //        if (skip >= trainercount) {
        //            $(".load").remove();
        //            //$("#trainercountform").remove()
        //        }


        //        //Old Partial
        //        //let a = "";

        //        //console.log(response);

        //        //for (let i = 0; i < response.length; i++) {
        //        //    a += `<div class="col-lg-4 col-md-6 d-flex align-items-stretch">
        //        //    <div class="member">
        //        //        <img src="assets/img/trainers/${response[i].image}" class="img-fluid" alt="">
        //        //            <div class="member-content">
        //        //                <h4>${response[i].name} ${response[i].id} ${response[i].surName}</h4>
        //        //                <span>${response[i].category.name}</span>
        //        //                <p>
        //        //                    ${response[i].info}
        //        //                </p>
        //        //                <div class="social">
        //        //                    <a href="${response[i].twitter}"><i class="bi bi-twitter"></i></a>
        //        //                    <a href=""><i class="bi bi-facebook"></i></a>
        //        //                    <a href=""><i class="bi bi-instagram"></i></a>
        //        //                    <a href=""><i class="bi bi-linkedin"></i></a>
        //        //                </div>
        //        //            </div>
        //        //        </div>
        //        //    </div>`
        //        //}


                

        //        //<div class="col-lg-4 col-md-6 d-flex align-items-stretch">
        //        //    <div class="member">
        //        //        <img src="~/assets/img/trainers/@trainer.Image" class="img-fluid" alt="">
        //        //            <div class="member-content">
        //        //                <h4>@trainer.Name @trainer.SurName</h4>
        //        //                <span>@trainer.Category.Name</span>
        //        //                <p>
        //        //                    @trainer.Info
        //        //                </p>
        //        //                <div class="social">
        //        //                    <a href=""><i class="bi bi-twitter"></i></a>
        //        //                    <a href=""><i class="bi bi-facebook"></i></a>
        //        //                    <a href=""><i class="bi bi-instagram"></i></a>
        //        //                    <a href=""><i class="bi bi-linkedin"></i></a>
        //        //                </div>
        //        //            </div>
        //        //        </div>
        //        //    </div>
        //    }
        //})
    })
})