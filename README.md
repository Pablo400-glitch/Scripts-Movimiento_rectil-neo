# Scripts - Movimiento rectilíneo

En este README voy a detallar lo que realice en la actividades de la entrega.

## Actividades 

### Actividad 1

a)

Cree el script MoveTo que se encarga de mover un objeto desde su posición hasta otra posicion. Está posición viene dada por otro gameObject, el vector del mismo se almacena en la variable ```goal```. 
> Este script lo he ido modificando para adaptarme a los requerimientos de cada actividad.

![alt text](images/1.png)
*Figura 1: Fichero MoveTo*

b)

Configure la variable ```y``` para que sea igual a 0 y me di cuenta de que 

c)

Al poner el valor de la ```y``` a 1 ...

![alt text](images/1.1.png)
*Figura 2: Modificar valores en el inspector*

d)


e)

Al duplicar los valores ```xyz``` y usando un debug.log se puede comprobar que los valores no se mantienen consistentes.

### Actividad 2

En la siguiente imagen se puede ver el script resultante de la actividad. En está actividad tuve que crear la variable ```speed```, normalizar el vector de ```goal``` y usar la variable ```Time.deltaTime```. Y luego dentro del método ```Translate``` multiplicar los 3 valores anteriormente mencionados. Se multiplica todo por ```Time.deltaTime``` con el objetivo de obtener una consistencia en el movimiento y que el objeto no dependa de que tan potente es tu ordenador.

![alt text](images/2.png)
*Figura 3 (La imagen está mal, revisar)*

### Actividad 3

A diferencia de la actividad anterior es que en está se ha dejado de utilizar la dirección del objetivo y ahora el objeto se mueve hacía la verdadera posición del objetivo.

![alt text](images/3.png)
*Figura 4: Modificaciones en el script MoveTo*

### Actividad 4

![alt text](images/4.png)
*Figura 5: Rayo apuntando hacía la posición objetivo*

### Actividad 5

En está actividad tuve un problema por culpa de los starter assets, al intentar importarlos al proyecto este perdía todas las texturas. Por lo tanto, tuve que crear un proyecto nuevo para está actividad en concreto.

Por defecto he utilizado el mismo script hasta ahora, pero le he añadido la función ```Increase Speed```.

Esta función me ha ayudado en el último apartado de está actividad para aumentar la velocidad del objeto.

![alt text](images/5.1.png)
*Figura 6:*

Para poder añadir los controles tuve que modificar ligeramente dos ficheros que tiene que ver con las ```InputActions``` del controlador del jugador y añadir un control para poder ir aumentando la velocidad con cada pulsación.

![alt text](images/5.3.png)
*Figura 8*

![alt text](images/5.4.png)
*Figura 9*

![alt text](images/5.5_(FirstPersonController).png)
*Figura 10*

![alt text](images/5.6_(FirstPersonController).png)
*Figura 11*

![alt text](images/5.7_(StarterAssetsinput).png)
*Figura 12*

![alt text](images/5.8_(StarterAssetsinput).png)
*Figura 13*

### Actividad 6

![alt text](images/6.1.png)
*Figura 14*

![alt text](images/6.2.png)
*Figura 15*

![alt text](images/6.3.png)
*Figura 16*

### Actividad 7

![alt text](images/7.1.png)
*Figura 17*

### Actividad 8

![alt text](images/7.2.png)
*Figura 18*

![alt text](images/8.png)
*Figura 19*

### Actividad 10 

![alt text](images/10-11.png)
*Figura 20*

### Actividad 11
