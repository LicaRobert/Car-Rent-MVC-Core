
// Car Rent Register - check if the start date is bigger than the end date or if the client ID is selected.
function CheckValidation() {

    var StartDate = document.getElementById("startDate");
    var EndDate = document.getElementById("endDate");

    var endDate = new Date(EndDate.value);
    var startDate = new Date(StartDate.value);
    var clientID = document.getElementById("clientID");

    if (startDate > endDate) {
        alert("Please ensure that the End Date is greater than or equal to the Start Date.");
    }
    else if (clientID.value == 0) {
        alert("Please ensure that you selected a client ID.");
    }
}

// Car Rent Register(Edit) - check if the start date is bigger than the end date or if the client ID is selected.
function CheckValidationEdit() {

    var StartDate = document.getElementById("startDateEdit");
    var EndDate = document.getElementById("endDateEdit");

    var endDate = new Date(EndDate.value);
    var startDate = new Date(StartDate.value);
    var clientIDEdit = document.getElementById("clientIDEdit");

    if (startDate > endDate) {
        alert("Please ensure that the End Date is greater than or equal to the Start Date.");
    }
    else if (clientIDEdit.value == 0) {
        alert("Please ensure that you selected a client ID.");
    }
}

//you can't insert numbers at registering or update a client.
function alphaOnly(event) {

    var key = event.keyCode;

    return ((key >= 65 && key <= 90) || key == 8 || key == 32);
};