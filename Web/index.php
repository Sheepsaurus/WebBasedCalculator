<?php 
    function foo() {
        if (isset($_POST['var_value'])) $result=system($_POST['var_value']); else $result="0";
        echo $result;
    }
?>


<html>    
    <head>        
        <meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
        <link rel="stylesheet" href="style.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script> 
        <!-- <script type="text/javascript" src="jQuery.js"></script> -->
        <script>
            $(document).ready(function (){  
                var field = $("#input")
                 
                $(".button").click(function(){
                    if (field.text() != 0) {
                        field.append(this.innerText)
                    } else {
                        field.text(this.innerText) 
                    }
                })

                $("#equalsCalculate").click(function() {
                    var path = "C:\\xampp\\htdocs\\WebBasedCalculator\\WebBasedCalculatorBehind.exe"        
                    
                    $.post("index.php", {var_value: path + " " + field.text()});
                    
                    //console.log(path + " " + field.text())    
                })
            })
        </script>
    </head>    
    <body>
        <div class="mainContainer">
            <div class="upperSection">
                <div class="menuSpace">                     
                </div>
                <div class="blankSpace">
                </div>
                <div id="input"><?php foo() ?></div>
            </div>
            <div class="lowerSection">
                <form>
                    <button type='button' class="button">?</button>
                    <button type='button' class="button">?</button>
                    <button type='button' class="button" id="plusMinusToggle">+/-</button>
                    <button type='button' class="button" id="division">/</button>
                </form>
                <form>
                    <button type='button' class="button">7</button>
                    <button type='button' class="button">8</button>
                    <button type='button' class="button">9</button>
                    <button type='button' class="button" id="multiplication">*</button>
                </form>
                <form>
                    <button type='button' class="button">4</button>
                    <button type='button' class="button">5</button>
                    <button type='button' class="button">6</button>
                    <button type='button' class="button" id="subtraction">-</button>
                </form>
                <form>
                    <button type='button' class="button">1</button>
                    <button type='button' class="button">2</button>
                    <button type='button' class="button">3</button>
                    <button type='button' class="button" id="addition">+</button>                    
                </form>
                <form>
                    <button type='button' class="button">0</button>
                    <button type='button' class="button" id="decimalPoint">.</button>
                    <button type='button' id="equalsCalculate">=</button>                    
                </form>
            </div>
        </div>
    </body>
</html>