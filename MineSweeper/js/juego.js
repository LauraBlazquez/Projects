class Juego {
    tablero;
    jugador;
    juegosIniciados = 0;
    juegoAcabado = false;

    static init() {
        const JUEGO = new Juego();
        JUEGO.valoresPorDefectoForm();
        JUEGO.configurar();
    }

    configurar() {
        let register = document.getElementById('register');
        let configIcon = document.getElementsByTagName('i');
        let popup = document.getElementById('popup');
        let registerForm = document.getElementById('registerForm');

        register.addEventListener('click', () => {
            popup.style.display = 'block';
        });

        configIcon[0].addEventListener('click', () => {
            popup.style.display = 'block';
            this.juegoAcabado = false;
        });

        registerForm.addEventListener('submit', (event) => {
            event.preventDefault();
            const USERNAME = document.getElementById('username').value;
            const SURNAME = document.getElementById('surname').value;
            const BIRTHDATE = document.getElementById('birthDate').value;
            const NICKNAME = document.getElementById('nickname').value;
            const EMAIL = document.getElementById('email').value;
            const ROWS = document.getElementById('rows').value;
            const COLS = document.getElementById('cols').value;
            const BOMBS = document.getElementById('bombs').value;

            this.jugador = new Jugador(USERNAME, SURNAME, NICKNAME, BIRTHDATE, EMAIL);

            let errors = 0;
            if (!RegExp(/.*[0-9]$/).test(NICKNAME)) {
                alert('El nickname tiene que acabar con un número');
                errors++;
            }
            else if (!RegExp(/.*@itb.cat$/).test(EMAIL)) {
                alert('El dominio del correo tiene que pertenecer a @itb.cat');
                errors++;
            }
            else if (this.jugador.getEdad() < 18) {
                alert('Debes ser mayor de edad para poder jugar.');
                errors++;
            }

            if (errors == 0) {
                this.tablero = new Tablero(COLS, ROWS, BOMBS);
                this.tablero.colocarBombas();

                localStorage.setItem('username', USERNAME);
                localStorage.setItem('surname', SURNAME);
                localStorage.setItem('birthDate', BIRTHDATE);
                localStorage.setItem('nickname', NICKNAME);
                localStorage.setItem('email', EMAIL);
                localStorage.setItem('rows', ROWS);
                localStorage.setItem('cols', COLS);
                localStorage.setItem('bombs', BOMBS);
                this.cambioEstilo();
                if (this.juegosIniciados == 0)
                    this.crearTablaDOM(this.tablero.columnas, this.tablero.filas);
                else {
                    let tableroDOM = document.getElementById('map');
                    let juego = tableroDOM.parentNode;
                    juego.removeChild(tableroDOM);
                    this.crearTablaDOM(this.tablero.columnas, this.tablero.filas);
                }
                this.juegosIniciados++;
            }
        });
    }

    cambioEstilo() {
        popup.style.display = 'none';
        register.style.display = 'none';
        let h1 = document.getElementsByTagName('h1');
        h1[0].style.marginTop = 0;
    }

    valoresPorDefectoForm() {
        let defaultUsername = localStorage.getItem("username");
        let defaultSurname = localStorage.getItem("surname");
        let defaultBirthDate = localStorage.getItem("nickname");
        let defaultNickname = localStorage.getItem("birthDate");
        let defaultEmail = localStorage.getItem("email");

        document.getElementById("username").value = defaultUsername;
        document.getElementById("surname").value = defaultSurname;
        document.getElementById("nickname").value = defaultBirthDate;
        document.getElementById("birthDate").value = defaultNickname;
        document.getElementById("email").value = defaultEmail;
    }

    crearTablaDOM(columnas, filas) {
        let resultado = `<table>`;
        for (let i = 0; i < columnas; i++) {
            resultado += `<tr>`;
            for (let j = 0; j < filas; j++) {
                if ((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0)) {
                    resultado += `<td columna="${i}" fila="${j}" class="tapadoPar"></td>`;
                }
                else {
                    resultado += `<td columna="${i}" fila="${j}" class="tapadoImpar"></td>`;
                }
            }
            resultado += `</tr>`;
        }
        resultado += `</table>`;
        let mapSection = document.createElement('div');
        mapSection.setAttribute('id', 'map');
        mapSection.innerHTML = resultado;
        let game = document.getElementById('game');
        game.appendChild(mapSection);
        this.eventosCeldas();
    }

    eventosCeldas() {
        let celdas = document.getElementsByTagName('td');
        for (let i = 0; i < celdas.length; i++) {
            celdas[i].addEventListener('contextmenu', (event) => {
                event.preventDefault();
                let columna = celdas[i].getAttribute('columna');
                let fila = celdas[i].getAttribute('fila');

                if (!this.tablero.casillas[columna][fila].bandera) {
                    this.tablero.casillas[columna][fila].marcar();
                    this.banderasColocadas++;
                } else {
                    this.tablero.casillas[columna][fila].desmarcar();
                }
                if (this.juegoAcabado == false)
                    celdas[i].innerText = this.tablero.casillas[columna][fila].bandera ? '🚩' : '';
                this.actualizaTablaDOM();
            });
            celdas[i].addEventListener('click', (event) => {
                event.preventDefault();
                let columna = parseInt(celdas[i].getAttribute('columna'));
                let fila = parseInt(celdas[i].getAttribute('fila'));

                let resultado = this.tablero.destapaCasilla(columna, fila);
                this.actualizaTablaDOM(resultado);
            });
        }
    }

    actualizaTablaDOM(resultado) {
        if (this.juegoAcabado == false) {

            let tablero = document.getElementById('map');
            let celdas = tablero.getElementsByTagName('td');

            for (let i = 0; i < celdas.length; i++) {
                let columna = celdas[i].getAttribute('columna');
                let fila = celdas[i].getAttribute('fila');

                if (this.tablero.casillas[columna][fila].revelada) {
                    if (celdas[i].getAttribute('class') == 'tapadoPar')
                        celdas[i].classList.replace('tapadoPar', 'destapadoPar');
                    else celdas[i].classList.replace('tapadoImpar', 'destapadoImpar');

                    if (this.tablero.casillas[columna][fila].tieneMina()) {
                        celdas[i].textContent = '💣';
                    }
                    else if (this.tablero.casillas[columna][fila].contenido != 0)
                        celdas[i].textContent = this.tablero.casillas[columna][fila].contenido;
                }
                else if (resultado && this.tablero.casillas[columna][fila].tieneMina() && this.tablero.casillas[columna][fila].bandera == false)
                    celdas[i].style.backgroundColor = 'red';

            }
            if (this.tablero.ganar()) {
                alert('¡Has ganado!');
                this.juegoAcabado = true;
            }
            if (resultado) {
                alert('Has perdido');
                this.juegoAcabado = true;
            }
        }
    }
}
