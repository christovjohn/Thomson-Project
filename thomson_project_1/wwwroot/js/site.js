// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.onload = function () {
    if (window.showPopupModal === true) {
        const myModal = new bootstrap.Modal(document.getElementById('inputModal'));
        myModal.hide();
    } else {
        const myModal = new bootstrap.Modal(document.getElementById('inputModal'));
        myModal.show();
    }
};


document.addEventListener("DOMContentLoaded", function () {
    const complaint = document.getElementById("complaintCheck");
    const enquiry = document.getElementById("enquiryCheck");

    complaint.addEventListener("change", function () {
        if (this.checked) {
            enquiry.checked = false;
        }
    });

    enquiry.addEventListener("change", function () {
        if (this.checked) {
            complaint.checked = false;
        }
    });
});


