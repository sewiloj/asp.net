(function () {
    const alertElement = document.getElementById("success-alert");
    const buttons = document.getElementById("buttons");
    const formElement = document.forms[0];

    const addNewItem = async () => {
        const formData = new FormData(formElement);
        const requestData = {
            Name: formData.get("Name"),
            Description: formData.get("Description"),
            IsVisible: formData.get("IsVisible") === "true" ? true : false,
        };

        const response = await fetch("/api/ajax", {
            method: "POST",
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify(requestData),
        });

        const responseJson = await response.json();

        if (responseJson.success) {
            alertElement.style.display = "block";
        }
    };
    buttons.addEventListener("click", () => {
        event.preventDefault();
        addNewItem().then(() => console.log("added successfully"));
    });
})();