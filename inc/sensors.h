#ifndef __sensors_H__
#define __sensors_H__

static int register_gyroscope_callback(appdata_s *ad);
static void gyroscope_cb(sensor_h sensor, sensor_event_s *event, void *data);

static int register_accelerometer_callback(appdata_s *ad);
static void accelerometer_cb(sensor_h sensor, sensor_event_s *event, void *data);


#endif /* __sensors_H__ */
