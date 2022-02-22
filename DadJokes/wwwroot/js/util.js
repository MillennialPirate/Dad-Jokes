var routeURL = location.protocol + "//" + location.host;
console.log(routeURL);
function submitJoke() {
    var Author = $("#Author").val();
    var Question = $("#Question").val();
    var Answer = $("#Answer").val();
    if (Question != "" && Answer != "") {
        var data = {
            Question: Question,
            Answer: Answer,
            Author: Author
        };
        console.log(data);
        $.ajax({
            url: routeURL + '/api/Jokes/SaveJoke',
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (response) {
                window.location.href = routeURL + "/Joke";
            },
            error: function (xhr) {
                window.alert("try again");
            }
        })
    }
    else {
        window.alert("Please fill the form completely");
    }
}
function updateJoke() {
    var Id = $("#Id").val();
    var Author = $("#Author").val();
    var Question = $("#Question").val();
    var Answer = $("#Answer").val();
    if (Question != "" && Answer != "") {
        var data = {
            Id : Id,
            Question: Question,
            Answer: Answer,
            Author: Author
        };
        console.log(data);
        $.ajax({
            url: routeURL + '/api/Jokes/SaveJoke',
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (response) {
                window.location.href = routeURL + "/Joke";
            },
            error: function (xhr) {
                window.alert("try again");
            }
        })
    }
    else {
        window.alert("Please fill the form completely");
    }
}