function myFunction() {
    let i;
    let node;
    let paragraph;
    for (i = 0; i< 10; i++) {
        paragraph = document.createElement("p");
        node = document.createTextNode(i);
        paragraph.appendChild(node);
        main.appendChild(paragraph);
    }
}

myFunction();