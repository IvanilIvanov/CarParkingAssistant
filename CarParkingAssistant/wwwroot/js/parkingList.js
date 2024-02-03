const searchBar = document.querySelector(".items-table-searchbar");
const button = document.querySelector(".items-table-search-button");
const allEntries = document.querySelectorAll(".items-table > tbody > tr");
const tableBody = document.querySelector(".items-table > tbody");
button.addEventListener("click", search);
document.addEventListener('keydown', handleKey)
console.log(allEntries)
function handleKey(event) {
    if (event.key === 'Enter') {
        search()
    }
}

function search() {
    const searchText = searchBar.value.trim();
    tableBody.innerHTML = "";
    if (searchText === "") {
        for (let i = 0; i < allEntries.length; i++) {
            const entry = allEntries[i];
            tableBody.appendChild(entry);
        }
    }

    for (let i = 0; i < allEntries.length; i++) {
        const entry = allEntries[i];
        const entryAddress = entry.querySelector("td:nth-child(1)").innerHTML;

        if (entryAddress.toLowerCase().includes(searchText.toLowerCase())) {
            tableBody.appendChild(entry);
        }
    }
}
