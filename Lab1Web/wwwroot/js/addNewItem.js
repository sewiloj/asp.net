(function () {
    const alertElement = document.getElementById("success-alert");
    const buttons = document.getElementById("buttons");
    const formElement = document.forms[0];

    const addNewItem = async () => {
        const formData = new FormData(document.getElementById('form'))
        const data = {}

        formData.forEach((key, value) => {
            data[value] = value[key];
        });

        const requestData = {
            method: 'POST',
            body: JSON.stringify(data)
        };

        const responseFetch = await fetch('/api/Ajax', requestData);
        const response = await responseFetch.json();
        if (response.success) {
            alertElement.style.display = 'block';
        }
    };
    buttons.addEventListener("click", () => {
        event.preventDefault();
        addNewItem().then(() => console.log("added successfully"));
    });
})();