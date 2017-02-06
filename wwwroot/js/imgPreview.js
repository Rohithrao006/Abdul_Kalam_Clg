    function PreviewImage() {
        var oFReader = new FileReader();
        console.log(document.getElementById("StudentPhoto").files);
        oFReader.readAsDataURL(document.getElementById("StudentPhoto").files[0]);

        oFReader.onload = function (oFREvent) {

            document.getElementById("PhotoPreview").src = oFREvent.target.result;
        };
    };
    function PreviewImage1() {
        var oFReader = new FileReader();
        oFReader.readAsDataURL(document.getElementById("StudentSign").files[0]);

        oFReader.onload = function (oFREvent) {
            console.log(oFREvent);
            document.getElementById("StudentSignPreview").src = oFREvent.target.result;
        };
    };
    function PreviewImage2() {
        var oFReader = new FileReader();
        oFReader.readAsDataURL(document.getElementById("ParentSign").files[0]);

        oFReader.onload = function (oFREvent) {
            document.getElementById("ParentSignPreview").src = oFREvent.target.result;
        };
    };
