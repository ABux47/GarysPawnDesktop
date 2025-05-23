window.downloadFile = (fileName, contentUrl) => {
    const a = document.createElement("a");
    a.href = contentUrl;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);

    console.log("site.js loaded");

};
