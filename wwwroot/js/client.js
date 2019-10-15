$(function () {

    var toastSoundEffect = new Audio('Media/toast.wav');

    $('.code').on('click', function () {
        toastSoundEffect.play();

        $("#productName").html($(this).data('product'));
        $('#discountCode').html($(this).data('code'));
        $('#toast').toast('show');
    });

    $(document).on('keyup', function (e) {
        if (e.key === 'Escape') {
            $('.toast').toast('hide');
        }
    });
})