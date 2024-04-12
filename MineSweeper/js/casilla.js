class Casilla {
    constructor() {
        this.contenido = 0;
        this.revelada = false;
        this.bandera = false;
    }

    revelar() {
        this.revelada = true
    }

    marcar() {
        this.bandera = true;
    }

    desmarcar() {
        this.bandera = false;
    }

    tieneMina() {
        if (this.contenido == -1) {
            return true;
        }
        return false;
    }

    ponerMina() {
        this.contenido = -1;
    }
}
