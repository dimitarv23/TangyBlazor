window.ShowToastr = (type, message) => {
    if (type == "success") {
        toastr.success(message, "Success!", { timeout: 5000 });
    }
    if (type == "error") {
        toastr.error(message, "Failure!", { timeout: 5000 });
    }
}

window.ShowSwal = (type, message) => {
    if (type == "success") {
        Swal.fire(
            'Success!',
            message,
            'success'
        )
    }
    if (type == "error") {
        Swal.fire(
            'Failure!',
            message,
            'error'
        )
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}