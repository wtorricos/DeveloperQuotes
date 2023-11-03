window.onload = function () {
    setQuoteIdQueryParam();
};

function setQuoteIdQueryParam() {
    const elements = document.getElementsByClassName('parchment');
    const parchmentId = elements && elements[0] && elements[0].id;
    if (parchmentId) {
        const url = new URL(window.location.href);
        url.searchParams.set('id', parchmentId);
        window.history.pushState({}, '', url.toString());
    }
}
