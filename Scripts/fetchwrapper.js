async function getFetch(url, modalNotificationRef = null, spinnerRef = null) {
    try {
        if (spinnerRef != null) {
            spinnerRef.show();
        }
        //await delay(1000);
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const responseData = await response.json();
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (responseData.Status == "failed" && modalNotificationRef != null) {
            showNotificationModal(responseData, modalNotificationRef);
        }
        return responseData;
    } catch (error) {
        console.error('Error fetching data:', error);
        //throw error; // Re-throw the error if you want to handle it further up the call stack
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

async function getFetchById(url, id, modalNotificationRef = null, spinnerRef = null) {
    try {
        if (spinnerRef != null) {
            spinnerRef.show();
        }
        const response = await fetch(url + '/' + id);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const responseData = await response.json();
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (responseData.Status == "failed" && modalNotificationRef != null) {
            showNotificationModal(responseData, modalNotificationRef);
        }
        return responseData;
    } catch (error) {
        console.error('Error fetching data:', error);
        //throw error; // Re-throw the error if you want to handle it further up the call stack
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

async function postFetchData(url, data, modalNotificationRef = null, spinnerRef = null) {
    try {
        if (spinnerRef != null) {
            spinnerRef.show();
        }
        //await delay(1000);
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            if (spinnerRef != null) {
                spinnerRef.hide();
            }
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const responseData = await response.json();
        //console.log(responseData);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (responseData.Status == "failed" && modalNotificationRef != null) {
            showNotificationModal(responseData, modalNotificationRef);
        }

        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

async function updateFetchData(url, id, data, modalNotificationRef =null, spinnerRef = null) {
    try {
        if (spinnerRef != null) {
            spinnerRef.show();
        }
        const response = await fetch(url + '/' + id, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
            body: JSON.stringify(data)
        });
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const responseData = await response.json();
        //console.log(responseData);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (responseData.Status == "failed" && modalNotificationRef != null) {
            showNotificationModal(responseData, modalNotificationRef);
        }

        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

async function deleteFetch(url, id) {
    try {

        const response = await fetch(url + '/' + id, {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json; charset=utf-8'
            },
        });
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const responseData = await response.json();
        //console.log(responseData);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (responseData.Status == "failed" && modalNotificationRef != null) {
            showNotificationModal(responseData, modalNotificationRef);
        }
        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

function showNotificationModal(resultNotification, modalNotificationRef) {
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

function delay(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

async function getMultipleFetch(urls, modalNotificationRef = null, spinnerRef = null) {
    try {
        if (spinnerRef != null) {
            spinnerRef.show();
        }
        //await delay(1000);

        const promises = urls.map(makeAPICall);
        const responsesData = await Promise.all(promises);

        if (spinnerRef != null) {
            spinnerRef.hide();
        }

        if (responsesData.some(r => r.Status == "failed") && modalNotificationRef != null) {
            showNotificationModal(responsesData, modalNotificationRef);
        }
        return responsesData;
    } catch (error) {
        console.error('Error fetching data:', error);
        //throw error; // Re-throw the error if you want to handle it further up the call stack
        if (spinnerRef != null) {
            spinnerRef.hide();
        }
        if (modalNotificationRef != null) {
            showNotificationModal(undefined, modalNotificationRef);
        }
    }
}

async function makeAPICall(endpoint) {
    const response = await fetch(endpoint);
    const data = await response.json();
    return data;
}

