document.addEventListener('DOMContentLoaded', function () {

    // --- Modal Logic ---
    const modalElement = document.getElementById('inputModal');
    if (modalElement) {
        const myModal = new bootstrap.Modal(modalElement);
        if (window.showPopupModal === true) {
            myModal.hide();
        } else {
            myModal.show();
        }
    }

    // --- Form Validation ---
    const sendPopupForm = document.getElementById("inputModal");
    if (sendPopupForm) {
        sendPopupForm.addEventListener("submit", function (e) {
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
    }

    // --- Complaint / Enquiry Toggle ---
    const complaintCheckbox = document.getElementById('complaintCheck');
    const enquiryCheckbox = document.getElementById('enquiryCheck');
    if (complaintCheckbox && enquiryCheckbox) {
        complaintCheckbox.addEventListener('change', function () {
            if (this.checked) enquiryCheckbox.checked = false;
        });
        enquiryCheckbox.addEventListener('change', function () {
            if (this.checked) complaintCheckbox.checked = false;
        });
    }

});
