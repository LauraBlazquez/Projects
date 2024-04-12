class Jugador {
    #edad;
    constructor(nombre, apellido, nick, fechaNacimiento, email) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.nick = nick;
        this.fechaNacimiento = fechaNacimiento;
        this.email = email;
        this.#edad = this.setEdad();
    }

    getEdad() {
        return this.#edad;
    }

    setEdad() {
        let birthDate = new Date(this.fechaNacimiento);
        let today = new Date();
        let age = today.getFullYear() - birthDate.getFullYear();
        if (birthDate > new Date(today.setFullYear(today.getFullYear() - age))) {
            age--;
        }
        return age;
    }
}
