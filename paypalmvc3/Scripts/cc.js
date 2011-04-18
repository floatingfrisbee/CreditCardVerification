$(document).ready(function () {
    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2011");

    $('#verifybutton').click(OnVerify);
    $('#clearbutton').click(OnClear);
    $('#populatebutton').click(OnPopulate);
});

function Block() {
    $('#allinfodiv').block({
        message: '<h1>Processing</h1>',
        css: { border: '1px solid #a00' }
    });
}

function OnVerify() {
    
    Block();

    var args = new Object();

    args.FirstName = $('#fnametb').val();
    args.LastName = $('#lnametb').val();

    args.CreditCardInfo = new Object();
    args.CreditCardInfo.Type = $('#cctypecombo').val();
    args.CreditCardInfo.CreditCardNumber = $('#cardnumbertb').val();
    args.CreditCardInfo.Cvv2Number = $('#cvv2numbertb').val();
    args.CreditCardInfo.ExpirationDate = $('#expdate').val();
    
    args.AddressInfo = new Object();
    args.AddressInfo.Address1 = $('#address1').val();
    args.AddressInfo.Address2 = $('#address2').val();
    args.AddressInfo.City = $('#city').val();
    args.AddressInfo.State = $('#state').val();
    args.AddressInfo.ZipCode = $('#zipcode').val();
    args.AddressInfo.Country = $('#country').val();

    var x = new Object();
    x.authorizationRequest = args;

    $.ajax({    
        url: 'home/verify',
        type: 'POST',
        data: JSON.stringify(x),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: OnVerifySuccess,
        error: function () {
            $('#allinfodiv').unblock();
        }
    });
}

function OnVerifySuccess(jsonResponse){
    $('#allinfodiv').unblock(); 
}

function OnClear() {
    $('input').each(function () {
        $(this).val('');
    });

    $('#cctypecombo').val('Visa');

    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2011");
}

function OnPopulate() {
    $('#fnametb').val('Goozon');
    $('#lnametb').val('Softel');
    $('#cctypecombo').val('Visa');
    $('#cardnumbertb').val('4683075410516684');
    $('#cvv2numbertb').val('123');

    $('#expdate').datepicker({ dateFormat: "mm/dd/yy" });
    $('#expdate').val("04/30/2011");
    
    $('#address1').val('1 Main St.');
    $('#address2').val('');
    $('#city').val('San Jose');
    $('#state').val('CA');
    $('#zipcode').val('95131');
    $('#country').val('US');
}