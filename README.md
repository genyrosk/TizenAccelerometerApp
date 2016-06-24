# Tizen Accelerometer + Gyroscope app

This app has been written in **C** for **Tizen 2.3.1**, using the Samsung Gear S2 watch. 
The goal of the project was to enable one to collect accelerometer and gyroscope data from the watch that can later be used for other development purposes.
These may include tracking user motions and advanced machine learning of the data. 

A user starts the data collection by pressing the **Start** button. Data collection ends when the user presses **Stop**. A .txt file is then saved inside the app's `media` folder with all the data. 


### Reason for the project

Tizen OS allows developpers to write apps in either C or HTML/Javascript. 
Writing in Javascript and HTML/CSS files is very easy and straightfoward. Tizen essentially abstracts virtually all functionality into an additional Web API that sits on top of the main API that is accessible in C.   
The ultimate reason for why this app was developped in C is **performance**: the frequency at which the app is able to get the sensor data. Using Javascript, developers are restricted to an about 35 ms time interval between calls. In C, you can go as low as **10 ms**. 


### Overview of the Project Structure

`/inc` - header files:
* `basicui.h`
* `sensors.h`

`/src` - source files:
* `basicui.c`:  

    ```c 
  	write_data(...) 		// -> writes the collected data onto a .txt file 
  	save_data(...) 			// -> saves the .txt file in the `/media` folder
  	_button_click_cb(...)  	// -> triggered on user press
  	create_base_gui(...)	// -> creates the app UI
  	app_create(...)			// -> initialises the app 
  	main(...)
    ```
* `sensors.c`:  

    ```c 
  	register_accelerometer_callback(...)
  	accelerometer_cb(...)
  	register_gyroscope_callback(...)
  	gyroscope_cb(...)
    ```

##### Important stuff

1. The **_app_data_** object, defined as a `struct` in `basicui.h`, holds all the important objects and data including **sensor variables** and objects and **UI elements**.  
2. `/src/basicui.c` is the main file and includes `int main()` the UI build and all data data collection functions.
3. `app_create()` is invoked and a UI is created with `create_base_gui(ad)` where `ad` is the pointer to the **_app_data_** object, defined as a `struct` in `basicui.h`.
4. `/src/sensors.c` contains all functions related to the sensors initialization and callback functions. 
5. The **_app_data_** pointer is passed around multiple functions and ultimately is used to save the collected data in a file, after which the data array variable is reset. 
6. `tizen-manifest.xml` is to be used to get **priveleges**, e.g. for writing and storing files in the device. 


### Sensors Initializers

In `sensors.c`:  
* `static int register_accelerometer_callback(...)`
* `static int register_gyroscope_callback(...)`

Tizen API functions that link to their respective callback and listening functions.   
They are called in the `app_create(...)` function of `/src/basicui.c`  
The **_app_data_** `ad` struct will point to the sensors objects:

```c
// inside register_accelerometer_callback(...)
sensor_h *accelerometer = ad->accelerometer;
sensor_listener_h *accelerationListener = ad->accelerationListener;
```


### Sensors Callbacks

In `sensors.c`:
* `static void accelerometer_cb(...)`  
* `static void gyroscope_cb(...)`

These functions are linked to the sensors in the sensor register functions. **But they do not need to be called manually.**   
In order to start listening to sensors and get data, invoke API function `sensor_listener_start(...)`:

```c
// start accelerometer
int error = sensor_listener_start(ad->accelerationListener);
```
where `ad` points to the **_app_data_** object and `accelerationListener` has been defined in the register function. 

The user starts data collection after pressing the **Start** button. The `_button_click_cb(...)` function is then called. It first checks the current state of the button, i.e. its title and either starts collection or saves the collected data. 

### Saved Data

Data is oganised in an array and saved in the **json** syntax in the following order: 

1. timestamp
1. accelerometer X
2. accelerometer Y
3. accelerometer Z
4. gyroscope X
5. gyroscope Y
6. gyroscope Z


### A few recommendations

You might consider delaying the data collection by a few seconds while the user positions himself and starts doing the activity of interest. 


