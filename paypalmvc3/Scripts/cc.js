$(document).ready(function () {
    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2012");

    $('#verifybutton').click(OnVerify);
    $('#clearbutton').click(OnClear);
    $('#populatebutton').click(OnPopulate);
});

function OnVerify() {
    alert('verify');
}

function OnClear() {
    $('input').each(function () {
        $(this).val('');
    });

    $('#cctypecombo').val('Visa');

    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2012");
}

function OnPopulate() {
    $('#fnametb').val('Jaspreet');
    $('#lnametb').val('Bakshi');
    $('#cctypecombo').val('Visa');
    $('#cardnumbertb').val('4683075410516684');
    $('#cvv2numbertb').val('123');

    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2012");
    
    $('#address1').val('One Infinity Drive');
    $('#address2').val('2363');
    $('#city').val('San Jose');
    $('#state').val('CA');
    $('#zipcode').val('95131');
    $('#country').val('US');
}