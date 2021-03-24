// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#album-table').DataTable({
    });

    $('#photo-table').DataTable({
    });
});

var getCommentsByPhotoId = function (photoId) {
    $.ajax({
        type: "GET",
        url: "/Comment/getCommentsByPhotoId",
        data: { "photoId": photoId },
        success: function (response) {
            console.log(response);

            var theTemplateScript = $("#comment-template").html();

            var theTemplate = Handlebars.compile(theTemplateScript);
            var model = {
                comment: []
            };

            model.comment = response;

            var theCompiledHtml = theTemplate(model);

            $("#comment-render").append(theCompiledHtml);

            $('html, body').animate({
                scrollTop: $('#comment-render').offset().top
            }, 500);
        },
        failure: function (response) {
            console.log(response);
        },
        error: function (response) {
            console.log(response);
        }
    });
}