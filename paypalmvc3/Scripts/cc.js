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

function OnVerifySuccess(authResponse){
    $('#allinfodiv').unblock();

    if (authResponse.IsSuccess) {
        $('#notemessagediv').html('<b>Thank You!</b> Your credentials have been verified. Credit card related information you provide is used only to verify your identity and is not persisted on our systems or used by us in any other way. Read more in our <a href="http://www.opspark.com/Home/PrivacyPolicy">privacy policy</a>');
    }
    else {
        $('#notemessagediv').html('<b>Sorry!</b> Your credentials could not be verified. Please check and ensure that the information below is accurate');
    }

    $('#notemessagediv').effect("pulsate", { times: 1 }, 1000);

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
    $('#fnametb').val('John');
    $('#lnametb').val('Smith');
    $('#cctypecombo').val('Visa');
    $('#cardnumbertb').val('4716195341648694');
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