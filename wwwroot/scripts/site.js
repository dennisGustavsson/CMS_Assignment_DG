
                        try {
  function burgerMenu() {
    var x = document.getElementById("myTopnav");
    if (x.className === "topnav") {
      x.className += " responsive";
    } else {
      x.className = "topnav";
    }
  }
  function handleResponsive() {
    const navigation = document.querySelectorAll(".topnav a:not(.burger-icon");

    // Check if the window width is greater than 600px
    if (window.innerWidth > 768) {
      // Remove the responsive styles
      navigation.forEach((link) => {
        link.style.display = "inline-block"; // Or any appropriate display value
      });
    } else {
      // navigation.forEach(link => {
      //     link.style.display = 'block'; // Or 'flex' or any appropriate display value
      //   });
    }
  }
  // Initial call to set the initial state based on the window width
  handleResponsive();

  // Attach a listener to window resize event
window.addEventListener("resize", handleResponsive);
} catch {}
/*
const footerPosition = (element, scrollHeight, innerHeight) => {
  try {
    const _element = document.querySelector(element);
    const isTallerThanScreen =
      scrollHeight >= innerHeight + _element.scrollHeight;
    _element.classList.toggle("position-fixedddd", !isTallerThanScreen);
    _element.classList.toggle("position-static", isTallerThanScreen);
  } catch {}
};

footerPosition("footer", document.body.scrollHeight, window.innerHeight);
*/

                        