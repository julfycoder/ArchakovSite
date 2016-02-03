/* File Created: января 2, 2016 */
function RequestManager() {
    var request = null;
    var _data = null;

    function SetData(data) {
        _data = encodeURIComponent("pageName") + "=" + encodeURIComponent(data);
    }
    this.CreateRequest = function (pageName, responser, _url) {

        request = new XMLHttpRequest();
        request.open("POST", _url);
        SetData(pageName);
        request.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        request.send(_data);

        request.onreadystatechange = responser;
    }
    this.InsertResponse = function () {
        if (request.status == 200 && request.readyState == 4) {
            docMan.InsertHTMLById("FloatContainer", request.responseText);
        }
    }
    this.ReplaceResponse = function () {
        if (request.status == 200 && request.readyState == 4) {
            var element = document.getElementById("MoreButtonContainer");
            docMan.RemoveElement(element);
            docMan.AppendHTML("FloatContainer", request.responseText);
        }
    }
}
function DocumentManager() {
    this.InsertHTMLById = function (elementId, HTML) {
        var element = document.getElementById(elementId);
        element.innerHTML = HTML;
    }
    this.InsertHTML = function (element, HTML) {
        element.innerHTML = HTML;
    }
    this.ClearElement = function (elementId) {
        var element = document.getElementById(elementId);
        element.innerHTML = null;
    }
    this.RemoveElementById = function (elementId) {
        var element = document.getElementById(elementId);
        element.parentNode.removeChild(element);
    }
    this.RemoveElement = function (element) {
        element.parentNode.removeChild(element);
    }
    this.AppendHTML = function (elementId, HTML) {
        var element = document.getElementById(elementId);
        element.innerHTML += HTML;
    }
}
var request = new RequestManager();
var docMan = new DocumentManager();
