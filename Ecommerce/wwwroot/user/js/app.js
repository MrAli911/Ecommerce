var email=document.querySelector("#id_email");
email.addEventListener("keyup" , function(){
  var e_fas_times=document.querySelector("#email-fas-times");
  var e_fas_check=document.querySelector("#email-fas-check");
  if (email.value.length ==0) {
      e_fas_times.style.display="block";
      e_fas_check.style.display="none";
      email.style.border="red 2px solid";
  } else {
    e_fas_times.style.display="none";
    e_fas_check.style.display="block";
    email.style.border="green 2px solid";
      
  }

});

var pass=document.querySelector("#id_password");
pass.addEventListener("keyup" , function(){
  var p_fas_times=document.querySelector("#pass-fas-times");
  var p_fas_check=document.querySelector("#pass-fas-check");
  if (pass.value.length ==0) {
      p_fas_times.style.display="block";
      p_fas_check.style.display="none";
      pass.style.border="red 2px solid";
      return false;
  } else {
    p_fas_times.style.display="none";
    p_fas_check.style.display="block";
    pass.style.border="green 2px solid";
      
  }

});

function validation(){
  
  if (email.value==0 || pass.value==0) {
    document.querySelector("#alert").style.display="block";
   document.querySelector("#alert").innerHTML="Please check email or password";
    return false;
  } else {
    document.querySelector("#alert").style.display="none";
   document.querySelector("#alert").innerHTML="";
  }
}


