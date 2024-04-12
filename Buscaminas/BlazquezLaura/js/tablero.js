class Tablero {
    constructor(filas = 24, columnas = 20, bombas = 99) {
        if (filas * columnas > bombas) {
            this.filas = filas;
            this.columnas = columnas;
            this.bombas = bombas;
        }
        else {
            alert("¡El número de bombas no cabe en este mapa! Se generará un mapa difícil.");
            this.filas = 24;
            this.columnas = 20;
            this.bombas = 99;
        }
        this.casillas = this.generarTablero();
    }

    generarTablero() {
        let mapa = [];
        for (let i = 0; i < this.columnas; i++) {
            let fila = [];
            for (let j = 0; j < this.filas; j++) {
                fila.push(new Casilla());
            }
            mapa.push(fila);
        }
        return mapa;
    }

    colocarBombas() {
        for (let i = 1; i <= this.bombas; i++) {
            let x, y;
            do {
                x = this.randomValue(this.columnas);
                y = this.randomValue(this.filas);
            } while (this.casillas[x][y].tieneMina());
            this.casillas[x][y].ponerMina();
            this.colocarNumeros(x, y);
        }
    }

    colocarNumeros(columna, fila) {
        let x = -1;
        let y = -1;

        if (columna == 0) x = 0;
        if (fila == 0) y = 0;

        for (let i = x; i <= 1; i++) {
            for (let j = y; j <= 1; j++) {
                if (i != 0 || j != 0) {
                    if (columna + i < this.columnas && fila + j < this.filas) {
                        if (!this.casillas[columna + i][fila + j].tieneMina()) {
                            this.casillas[columna + i][fila + j].contenido++;
                        }
                    }
                }
            }
        }
    }

    destapaCasilla(columna, fila) {
        if (this.casillas[columna][fila].bandera) return;
        if (this.casillas[columna][fila].revelada) return;
        this.casillas[columna][fila].revelar();

        if (this.casillas[columna][fila].contenido == 0) {
            let x = -1;
            let y = -1;

            if (columna == 0) x = 0;
            if (fila == 0) y = 0;

            for (let i = x; i <= 1; i++) {
                for (let j = y; j <= 1; j++) {
                    let nuevaColumna = columna + i;
                    let nuevaFila = fila + j;

                    if (columna + i < this.columnas && fila + j < this.filas) {
                        this.destapaCasilla(nuevaColumna, nuevaFila);
                    }
                }
            }
        }
        if (this.casillas[columna][fila].tieneMina() && this.casillas[columna][fila].revelada) return true;
    }

    ganar() {
        let casillasRestantes = this.filas * this.columnas - this.bombas;
        let casillasReveladas = 0;
        let banderasColocadas = 0;

        for (let i = 0; i < this.columnas; i++) {
            for (let j = 0; j < this.filas; j++) {
                if (this.casillas[i][j].revelada) {
                    casillasReveladas++;
                }
                if (this.casillas[i][j].bandera && this.casillas[i][j].tieneMina()) {
                    banderasColocadas++;
                }
            }
        }

        if (casillasReveladas == casillasRestantes && banderasColocadas == this.bombas) {
            return true;
        }
        return false;
    }

    randomValue(max) {
        return Math.floor(Math.random() * max);
    }
}