async function getFetch(url) {
    try {
        const response = await fetch(url);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();
        return data;
    } catch (error) {
        console.error('Error fetching data:', error);
        //throw error; // Re-throw the error if you want to handle it further up the call stack
    }
}

async function getFetchById(url, id) {
    try {
        const response = await fetch(url + '/' + id);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();
        return data;
    } catch (error) {
        console.error('Error fetching data:', error);
        //throw error; // Re-throw the error if you want to handle it further up the call stack
    }
}

async function postFetchData(url, data) {
    try {
        const response = await fetch(url, {
            method: 'POST',
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
        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
    }
}

async function updateFetchData(url, id, data) {
    try {

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
        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
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
        return responseData;
    } catch (error) {
        console.error('Error during POST operation:', error);
    }
}

