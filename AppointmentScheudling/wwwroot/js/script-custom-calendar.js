$(document).ready(function () {
    InitializeCalendar();
});

function InitializeCalendar() {
    try {

        var calendarE1 = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarE1, {
            initialView: 'dayGridMonth'
            headerToolbar: {
                left: 'prev,next,today',
                center: 'title',
                right: 'dayGridMonth,timeGridWeek,timeGridDay'
            },
            Selection: true,
            editable: false,
            select: function (event) {
                onShowModal(event, null);
            }
        });
        calendar.render();

    }
    catch (e) {
        alert(e);
    }
}

function onShowModal(obj, isEventDetail) {
    $("#appointmentInput").modal("show");
}

function onCloseModal() {
    $("#appointmentInput").modal("hide");
}