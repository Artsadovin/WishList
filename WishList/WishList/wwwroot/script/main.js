import { ApiService } from "./api-service.js";

let wishCardTemplate = document.getElementById("wish-card-template");
let wishCardsContainer = document.getElementById("wishes-list-container");

function reloadWishesList() {
    let wishCards = [];

    ApiService.loadWishes((response) => {

        for (let wish of response) {
            let card = wishCardTemplate.innerHTML;

            card = card.replaceAll("{date}", wish.created);
            card = card.replaceAll("{type}", wish.type);

            card = `<div class="wish-card">${card}</div>`
            wishCards.push(card);
        }

        wishCardsContainer.innerHTML = wishCards.join();
    });
}


function removeWish(wishId) {
    ApiService.removeUser(wishId, reloadWishesList)
}

function addWish() {
    const type = $("#type-input").val();

    ApiService.addWish(type, reloadUsersList)
}

//window.removeWish = removeWish;
//window.addWish = addWish;


reloadWishesList();