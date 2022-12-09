function validateForm(){
    let namee=document.getElementById("uname").value;
    // console.log(namee)  //the values print out side the website
    let pass=document.getElementById("upass").value;
    // console.log(pass)  //the values print out side the website
    let addresss=document.getElementById("uaddress");
    

    if(namee == "" ){
        alert("Name can't be blank")
      
        return false;
    }
    if(namee.length<6){
      alert("Name must be at least ")
      return false;
    }
    if(pass == ""){
        alert("Password can't be blank")
        return false;
    }
    if(pass.value.length<6){
        alert("Password must be at least 6 characters long.")
        return false;
    }
    if(addresss.value== ""){
        alert("Address should not be empty")
    }
    }