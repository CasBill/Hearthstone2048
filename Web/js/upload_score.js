function uploadScore(name, score) {
    $.ajax({
        url: '/rank.asmx/uploadScore',
        data: '{name:"' + name + '", score: ' + score + '}',
        type: "POST",
        dataType: "json",
        contentType: "application/json"
    });
}