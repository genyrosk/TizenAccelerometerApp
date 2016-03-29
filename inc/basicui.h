#ifndef __basicui_H__
#define __basicui_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <sensor.h>
#include <string.h>
#include <time.h> 	/* time_t, struct tm, time, localtime */
#include <math.h>

typedef struct appdata {
    /* application acceleration data */
	float aX;
	float aY;
	float aZ;

    /* application gyroscope data */
	float rX;
	float rY;
	float rZ;

	/* application timestamps */
	float timestamp;		// accelerometer
	float start_t;
	float timestamp_g;		// gyroscope
	float start_t_g;
	char sys_time[30];		// general (system)
	struct tm * timeinfo;

	/* Other objects */
	FILE * fp;

	/* accelerometer objects */
    sensor_h accelerometer;
    sensor_listener_h accelerationListener;

    /* accelerometer objects */
    sensor_h gyroscope;
    sensor_listener_h gyroscopeListener;

    /* array containing all the data (to be saved in a file) */
    float all_data[30000][8];
    int i;
    int j;

	/* application GUI objects */
	Evas_Object *win;
	Evas_Object *conform, *nf;
	Evas_Object *box;
	Evas_Object *label, *label2;
	Evas_Object *button;
	Eina_Counter *counter;
} appdata_s;

static void accelerometer_cb(sensor_h sensor, sensor_event_s *event, void *data);
static int register_accelerometer_callback(appdata_s *ad);

static void gyroscope_cb(sensor_h sensor, sensor_event_s *event, void *data);
static int register_gyroscope_callback(appdata_s *ad);

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "basicui"

#if !defined(PACKAGE)
#define PACKAGE "org.example.basicui"
#endif

#endif /* __basicui_H__ */
