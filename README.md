# CommandPattern - Rod Gonzalez.
 Implementacion del patron Command


En este proyecto veran una esfera que puede moverse de forma lateral con dos inputs distintos.
Esta se movera al presionar las teclas A/D y al presionar los botones en pantalla LEFT/RIGHT.

Este proyecto necesita que un mismo objeto responda de igual manera a distintos imputs de usuario.
Hacer con esto sin el patron command seria engorroso y probablemente repitieramos mucho codigo.

Al utilizar el patron Command podemos hacer que las clases que manejan el input de usuario generen "Ordenes" de movimiento. Estas se encargan de llamar al metodo que mueve el objeto.
De esta manera la clase que maneja el input solo debe crear la orden de mover al personaje ante distintos eventos, delegando la responsabilidad de la accion a otras clases.

Una ventaja clara de esta implementacion es la extensibilidad. ya que respeta el principio Abierto Cerrado.
Tambien es hace que sea muy facil crear nuevas formas de manipular al personaje. Ejemplo de esto es una clase que permita crear estas "Ordenes" al recibir input de un Joystick.

Quizas la desventaja mas clara de este patron es que se debe crear una clase por cada accion que se requiera hacer. Esto puede hacer que a la larga se generen muchas clases y el codigo se vuelva demasiado complejo.

