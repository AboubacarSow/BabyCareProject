document.addEventListener('DOMContentLoaded', function () {
    var modals = document.querySelectorAll('.modal');

    modals.forEach(function (modal) {
        modal.addEventListener('show.bs.modal', function (event) {
            var button = event.relatedTarget;
            var videoUrl = button.getAttribute('data-src');
            var iframe = modal.querySelector('iframe');

            if (iframe && videoUrl) {
                iframe.src = videoUrl + "?autoplay=1&modestbranding=1&rel=0";
            }
        });

        modal.addEventListener('hidden.bs.modal', function () {
            var iframe = modal.querySelector('iframe');
            if (iframe) {
                iframe.src = ""; // Stop video on close
            }
        });
    });
});