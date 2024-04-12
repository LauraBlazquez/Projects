//Declaración de constantes.
const MAX_ATTEMPTS = 10;
const COLORS = ['white', 'blue', 'green', 'violet', 'yellow', 'red', 'orange', 'cyan'];
const GREY = "grey";
const WHITE = "white";
const BLACK = "black";

//Declaración de variables globales.
let attempt = 0;
let attempsWords = ['Segundo', 'Tercer', 'Cuarto', 'Quinto', 'Sexto', 'Séptimo', 'Octavo', 'Noveno', 'Último'];
let correctPositions = 0;
let master;
let userInput = [];

function init() {
    //1. Genera el código random del master
    MasterGenerator();
    console.log(master);
    //2. Crea todas las filas según el número de intentos.
    PrintAttempts();
}

function MasterGenerator() {
    master = [COLORS[RandomColors()], COLORS[RandomColors()], COLORS[RandomColors()], COLORS[RandomColors()]];
}
function RandomColors() {
    return Math.floor(Math.random() * COLORS.length);
}

/* Llamaremos a esta función desde el botón HTML de la página para comprobar la propuesta de combinación que nos ha
introducido el usuario. Informamos al usuario del resultado y del número de intentos que lleva*/
function Verify() {
    correctPositions = 0;
    CreateUserInput();
    if (userInput.length == master.length) {
        let masterCopy = [...master];
        for (let i = 0; i < master.length; i++) {
            if (masterCopy.includes(userInput[i])) {
                for (let j = 0; j < master.length && masterCopy[i] != null; j++) {
                    if (masterCopy[j] == userInput[i]) {
                        if (i == j) { 
                            AddColorTry('black',i);
                            masterCopy[i] = null;
                            correctPositions++;
                        }
                        else { AddColorTry('white',i) }
                    }
                }
            }
        }
        AddColorAttempt();
        EndGame();
        DeleteInput();
        AttemptChange();
        attempt++;
    }
    else { userInput = [] };
}

function CreateUserInput() {
    let userInputCels = document.querySelectorAll('.color');
    console.log(master);
    for (let color of userInputCels) {
        if (color.style.backgroundColor != '')
            userInput.push(color.style.backgroundColor);
    }
}

function AddColorAttempt() {
    let attemptColorCels = document.querySelectorAll('.celUserCombi');
    for (let i = 0; i < userInput.length; i++) {
        attemptColorCels[i + 4 * attempt].style.backgroundColor = userInput[i];
    }
}

function AddColorTry(color, position) {
    let answer = document.querySelectorAll('.cercleResult');
    answer[position + 4 * attempt].style.backgroundColor = color;
}

function DeleteInput() {
    let userInputCels = document.querySelectorAll('.color');
    for (let i = 0; i < userInputCels.length; i++) {
        userInputCels[i].style.backgroundColor = '';
    }
    userInput = [];
}

function AttemptChange() {
    let enunciadoIntento = document.getElementById('info');
    enunciadoIntento.textContent = attempsWords[attempt] + ' intento, suerte!';
}

/** Procedimiento que se ejecuta cada vez que el usuario selecciona un color, hasta el número máximo de colores permitidos en la combinación. */
function AddColor(color) {
    let userInputCels = document.querySelectorAll('.color');
    for (let i = 0; i < userInputCels.length; i++) {
        if (userInputCels[i].style.backgroundColor == '') {
            return userInputCels[i].style.backgroundColor = color;
        }
    }
}

function DeleteLastInput() {
    let userInputCels = document.querySelectorAll('.color');
    for (let i = userInputCels.length - 1; i >= 0; i--) {
        if (userInputCels[i].style.backgroundColor !== '') {
            return userInputCels[i].style.backgroundColor = '';
        }
    }
}

/** Template con el código HTML que corresponde a cada fila de juego/intento. */
function PrintAttempts() {
    const ROW_RESULT = `<div class="rowResult w100 flex wrap">
                            <div class="rowUserCombi w75 flex wrap">
                                <div class="w25">
                                    <div class="celUserCombi flex"></div>
                                </div>
                                <div class="w25">
                                    <div class="celUserCombi flex"></div>
                                </div>
                                <div class="w25">
                                    <div class="celUserCombi flex"></div>
                                </div>
                                <div class="w25">
                                    <div class="celUserCombi flex"></div>
                                </div>
                            </div>
                            <div class="rowCercleResult w25 flex wrap center">
                                <div class="w40 h40">
                                    <div class="cercleResult flex"></div>
                                </div>
                                <div class="w40 h40">
                                    <div class="cercleResult flex"></div>
                                </div>
                                <div class="w40 h40">
                                    <div class="cercleResult flex"></div>
                                </div>
                                <div class="w40 h40">
                                    <div class="cercleResult flex"></div>
                                </div>
                            </div>
                        </div>`;
    let sectionResult = document.getElementById('Result');
    for (let i = 0; i <= MAX_ATTEMPTS - 1; i++) {
        let newAttempt = document.createElement('article');
        newAttempt.innerHTML = ROW_RESULT;
        sectionResult.appendChild(newAttempt);
    }
}

function EndGame() {
    if (correctPositions === master.length) {
        alert('Felicidades has ganado');
        DisableUserInput();
        ShowMaster();
    }
    else if (attempt == MAX_ATTEMPTS - 1) {
        alert('Has agotado el número de intentos. Suerte la próxima vez');
        DisableUserInput();
    }
}

function ShowMaster() {
    let masterCels = document.querySelectorAll('.master');
    for (let i = 0; i < masterCels.length; i++) {
        masterCels[i].style.backgroundColor = userInput[i];
    }
}

function DisableUserInput() {
    let colorOptions = document.querySelectorAll('.cel');
    let verifyButton = document.querySelector('#check');
    verifyButton.removeAttribute('onclick');
    for (let element of colorOptions) {
        element.removeAttribute('onclick');
    }
}