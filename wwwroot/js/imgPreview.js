    function PreviewImage() {
        var oFReader = new FileReader();
        console.log(document.getElementById("StudentPhoto").files);
        oFReader.readAsDataURL(document.getElementById("StudentPhoto").files[0]);

        oFReader.onload = function (oFREvent) {

            document.getElementById("PhotoPreview").src = oFREvent.target.result;
            //document.getElementById("PhotoPreview").setAttribute("width","100");
            //document.getElementById("PhotoPreview").setAttribute("height","100");
        };
    };
    function PreviewImage1() {
        var oFReader = new FileReader();
        oFReader.readAsDataURL(document.getElementById("StudentSign").files[0]);

        oFReader.onload = function (oFREvent) {
            console.log(oFREvent);
            document.getElementById("StudentSignPreview").src = oFREvent.target.result;
            //document.getElementById("StudentSignPreview").setAttribute("width","200");
            //document.getElementById("StudentSignPreview").setAttribute("height","50");
        };
    };
    function PreviewImage2() {
        var oFReader = new FileReader();
        oFReader.readAsDataURL(document.getElementById("ParentSign").files[0]);

        oFReader.onload = function (oFREvent) {
            document.getElementById("ParentSignPreview").src = oFREvent.target.result;
            //document.getElementById("ParentSignPreview").setAttribute("width","200");
            //document.getElementById("ParentSignPreview").setAttribute("height","50");
        };
    };
