export class ApiService {

    static loadWishes(successFunction) {
        ApiService.makeGetRequest("wish", successFunction)
    }

    static removeWish(wishId, successFunction) {
        ApiService.makeGetRequest(`wish/${wishId}/remove`, successFunction)
    }

    static addUser(wishType, userAge, successFunction) {
        ApiService.makePostRequest(`user`, { name: userName, age: userAge }, successFunction)
    }

    static makeGetRequest(requestUrl, successFunction) {
        $.ajax({
            method: "GET",
            url: requestUrl,
        }).done(successFunction);
    }

    static makePostRequest(requestUrl, data, successFunction) {
        $.ajax({
            method: "POST",
            contentType: "application/json",
            url: requestUrl,
            data: JSON.stringify(data)
        }).done(successFunction);
    }
}