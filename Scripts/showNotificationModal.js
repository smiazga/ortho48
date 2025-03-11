function showNotificationModal(resultNotification,modalNotificationRef) {
    const modalNotificationComponent = modalNotificationRef
    if (modalNotificationComponent) {
        if (resultNotification == undefined) {
            modalNotificationComponent.notificationDisplay('error', '');
        }
        else if (resultNotification.Status == "failed") {
            modalNotificationComponent.notificationDisplay('error', resultNotification.Message);
        }
        else if (resultNotification.Status == "success") {
            modalNotificationComponent.notificationDisplay('info', resultNotification.Message);
        }
    }
}

