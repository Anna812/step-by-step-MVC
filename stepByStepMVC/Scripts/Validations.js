function isFirstNameEmpty() {
    if (document.getElementById('TxtFirstName').value == "") {
        return 'First name should not be empty';
    }
    else {
        return '';
    }
}

function isFirstNameInvalid() {
    if (document.getElementById('TxtFirstName').value.indexOf("@") != -1) {
        return 'First name cannot contain @';
    }
    else {
        return '';
    }
}

function isLastNameInvalid() {
    if (document.getElementById('TxtLastName').value.length > 5) {
        return 'Last name cannot contain more than 5 characters';
    }
    else {
        return '';
    }
}

function isSalaryEmpty() {
    if (document.getElementById('TxtSalary').value == "") {
        return 'Salary should not be empty';
    }
    else {
        return '';
    }
}

function isSalaryInvalid() {
    if (isNaN(document.getElementById('TxtSalary').value)) {
        return 'Enter valid salary';
    }
    else {
        return '';
    }
}

function isValid() {
    var FirstNameEmptyMessage = isFirstNameEmpty();
    var FirstNameInvalidMessage = isFirstNameInvalid();
    var LastNameInvalidMessage = isLastNameInvalid();
    var SalaryEmptyMessage = isSalaryEmpty();
    var SalaryInvalidMessage = isSalaryInvalid();
    var FinalErrorMessage = "Errors:";

    if (FirstNameEmptyMessage != "") {
        FinalErrorMessage += "\n" + FirstNameEmptyMessage;
    }
    if (FirstNameInvalidMessage != "") {
        FinalErrorMessage += "\n" + FirstNameInvalidMessage;
    }
    if (LastNameInvalidMessage != "") {
        FinalErrorMessage += "\n" + LastNameInvalidMessage;
    }
    if (SalaryEmptyMessage != "") {
        FinalErrorMessage += "\n" + SalaryEmptyMessage;
    }
    if (SalaryInvalidMessage != "") {
        FinalErrorMessage += "\n" + SalaryInvalidMessage;
    }

    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    } else {
        return true;
    }
}