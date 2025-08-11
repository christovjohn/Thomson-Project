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
document.getElementById("SendPopupEmail").addEventListener("submit", function (e) {
    // Silent check: if any required field is empty, stop submit
    let isValid = true;
    this.querySelectorAll("[required]").forEach(function (input) {
        if (!input.value.trim()) {
            isValid = false;
        }
    });
    if (!isValid) {
        e.preventDefault();
    }
});


document.addEventListener('DOMContentLoaded', function () {
    const complaintCheckbox = document.getElementById('complaintCheck');
    const enquiryCheckbox = document.getElementById('enquiryCheck');

    if (complaintCheckbox && enquiryCheckbox) {
        complaintCheckbox.addEventListener('change', function () {
            if (this.checked) {
                console.log("checked1");
                enquiryCheckbox.checked = false;
            }
        });

        enquiryCheckbox.addEventListener('change', function () {
            if (this.checked) {
                console.log("checked2");
                complaintCheckbox.checked = false;
            }
        });
    }
});


