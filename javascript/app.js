function URLify() {
    let stringToURL = 'trevor is the greatest';
    let newString = stringToURL.replace(/ /gi, '%20');
    let node;
    let paragraph;
    paragraph = document.createElement("p");
    node = document.createTextNode(newString);
    paragraph.appendChild(node);
    main.appendChild(paragraph);
}

URLify();