$(document).ready(function () {
  //navbar active link
  $("#navbarSupportedContent a").click(function () {
    $("#navbarSupportedContent a").removeClass("active");
    $(this).addClass("active");
  });

    var imgSrc;
  //inkyy and image hover
  $("#intro .content").hover(
      function () {
          imgSrc = $(this).find("img").attr("src");
          var changedSrc = $(this).find("img").data("hover-img");

          $(this).find("img").attr("src", changedSrc);
      $(this).find("h3").css("color", "black");
    },
      function () {
          $(this).find("img").attr("src", imgSrc);
      $(this).find("h3").css("color", "#E4E7EC");
    }
  );

  // why section sider mobile
  var windowB = $(window).width();

  if (windowB < 576) {
    $("#why .slider").slick({
      centerMode: true,
      centerPadding: "50px",
      slidesToShow: 1,
      arrows: false,
      dots: true,
      dotsClass: "slick-dots",
    });

    //offer section slider mobile
    $("#offer .slider").slick({
      centerMode: true,
      centerPadding: "50px",
      slidesToShow: 1,
      prevArrow: $("#offer .sliderBtn .prev"),
      nextArrow: $("#offer .sliderBtn .next"),
    });
  }

  //testimonial section slider

  $(".testimonial-slider").slick({
    infinite: true,
    slidesToShow: 3,
    slidesToScroll: 2,
    arrows: false,
    dots: true,

    responsive: [
      {
        breakpoint: 576,
        settings: {
          centerMode: false,
          slidesToShow: 1,
          slidesToScroll: 4,
          infinite: true,
          dots: true,
          arrows: false,
        },
      },
    ],
  });

  //message validation

  $("#message .send").click(function (e) {
    e.preventDefault();

    var name = $("#message .drop input[type='name']");
    var email = $("#message .drop input[type='email']");
    var txt = $("#message .drop textarea[name='message']");
    var labelEmail = $("#message .drop label[for='email']");
    var labelName = $("#message .drop label[for='name']");

    if (name.val() == "") {
      name.css("background-color", "#ffc1c1");
      name.attr("placeholder", "Fill the input!!!");
    } else {
      name.css("background-color", "#EFF2FA");
      name.attr("placeholder", "");
    }

    function validateEmail(email) {
      const re = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      return re.test(email.val());
    }

    function validateName(name) {
      const re = /^[a-zA-Z\s]*$/;

      return re.test(name.val());
    }
    function emailValidation() {
      if (validateEmail(email)) {
        labelEmail.hide();
        return true;
      } else {
        labelEmail.show();
        return false;
      }
    }

    function nameValidation() {
      if (!validateName(name)) {
        labelName.show();
        return false;
      } else {
        labelName.hide();
        return true;
      }
    }

    if (email.val() == "") {
      email.css("background-color", "#ffc1c1");
      email.attr("placeholder", "Fill the input!!!");
    } else {
      email.css("background-color", "#EFF2FA");
      email.attr("placeholder", "");
    }

    if (txt.val() == "") {
      txt.css("background-color", "#ffc1c1");
      txt.attr("placeholder", "Fill the input!!!");
    } else {
      txt.css("background-color", "#EFF2FA");
      txt.attr("placeholder", "");
    }

    name.focus(function (e) {
      e.preventDefault();
      $(this).css("background-color", "#EFF2FA");
      $(this).attr("placeholder", "");
    });

    email.focus(function (e) {
      e.preventDefault();
      $(this).css("background-color", "#EFF2FA");
      $(this).attr("placeholder", "");
    });

    txt.focus(function (e) {
      e.preventDefault();
      $(this).css("background-color", "#EFF2FA");
      $(this).attr("placeholder", "");
    });

    if (name.val() != "" && email.val() != "" && txt.val() != "") {
      if (emailValidation() && nameValidation()) {
        $(".success").fadeIn();
        document.forms[0].reset();

        setTimeout(function () {
          $(".success").fadeOut();
        }, 3000);
      }
    } else {
      $(".success").fadeOut();
    }
  });
});
