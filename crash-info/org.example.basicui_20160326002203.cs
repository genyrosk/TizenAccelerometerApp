S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 2872
Date: 2016-03-26 00:22:03+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x4142dec0, r1   = 0x4155edaa
r2   = 0xbe820d00, r3   = 0x00000010
r4   = 0xbe820d08, r5   = 0xbe820d00
r6   = 0x00000000, r7   = 0xbe820da4
r8   = 0xbe820ec4, r9   = 0x4004dc40
r10  = 0x4155edaa, fp   = 0xbe820cec
ip   = 0x404bb140, sp   = 0xbe820788
lr   = 0x404b1ee4, pc   = 0x404b1ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14608 KB
Buffers:     15848 KB
Cached:     171084 KB
VmPeak:      68892 KB
VmSize:      68888 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15132 KB
VmRSS:       15128 KB
VmData:      13432 KB
VmStk:        1012 KB
VmExe:          20 KB
VmLib:       22740 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41530000 41534000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4153c000 41544000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 4155f000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
41568000 41569000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 41975000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4197e000 4199f000 r-xp /usr/lib/libefl-extension.so.0.1.0
419a7000 419c5000 r-xp /usr/lib/libsensor.so.1.1.0
419cf000 419e1000 r-xp /usr/lib/libefl-assist.so.0.1.0
419e9000 41aa1000 r-xp /usr/lib/libcairo.so.2.11200.14
41aac000 41ab3000 r-xp /usr/lib/libsensord-share.so
41abb000 41acd000 r-xp /usr/lib/libtts.so
41ad5000 41af6000 r-xp /usr/lib/libui-extension.so.0.1.0
41aff000 41b06000 r-xp /usr/lib/libtbm.so.1.0.0
41b0e000 41b1c000 r-xp /usr/lib/libGLESv2.so.2.0
41b25000 41b2b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b33000 41b36000 r-xp /usr/lib/libEGL.so.1.4
41b3e000 41b43000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b4b000 41c88000 r-xp /usr/lib/libicui18n.so.51.1
41c98000 41d7c000 r-xp /usr/lib/libicuuc.so.51.1
41d91000 41d94000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d9c000 41da4000 r-xp /usr/lib/libdrm.so.2.4.0
43333000 43338000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43341000 43346000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4334e000 43350000 r-xp /usr/lib/libdri2.so.0.0.0
43358000 43379000 r-xp /usr/lib/libexif.so.12.3.3
4338c000 43391000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43399000 43463000 r-xp /usr/lib/libCOREGL.so.4.0
43675000 43680000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43689000 4368d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43695000 436ac000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
436b9000 436bb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
be816000 be90c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2872)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0x404b1ee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0x404bb15c) [/lib/libc.so.6] + 0x4615c
 2: save_data + 0xc0 (0x4155eb55) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1b55
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
settings_get_item], key=14
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
03-26 00:18:09.715+0100 E/TIZEN_N_SYSTEM_SETTINGS(  702): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
03-26 00:18:09.730+0100 W/WATCH_CORE(  702): appcore-watch.c: __widget_resume(1012) > widget_resume
03-26 00:18:09.730+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:09.745+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [powerkey]
03-26 00:18:09.745+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
03-26 00:18:09.765+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
03-26 00:18:09.765+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
03-26 00:18:09.765+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
03-26 00:18:09.765+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_set_param(1248) > [SVOICE] set param [keyword length] : 0
03-26 00:18:09.775+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
03-26 00:18:09.775+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Enable start
03-26 00:18:09.780+0100 W/W_HOME  (  681): gesture.c: _widget_updated_cb(190) > widget updated
03-26 00:18:09.780+0100 W/W_HOME  (  681): gesture.c: _manual_render_disable_timer_del(151) > timer del
03-26 00:18:09.780+0100 W/W_HOME  (  681): gesture.c: _manual_render(176) > 
03-26 00:18:09.800+0100 W/W_HOME  (  681): gesture.c: _manual_render(176) > 
03-26 00:18:09.885+0100 W/W_HOME  (  681): gesture.c: _manual_render_enable(133) > 0
03-26 00:18:09.885+0100 I/SHealth_Common( 1012): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
03-26 00:18:09.895+0100 I/SHealth_Service( 1012): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
03-26 00:18:10.010+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:10.055+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-26 00:18:10.055+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:18:10.055+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
03-26 00:18:10.055+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
03-26 00:18:10.075+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:18:10.690+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.690+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.690+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.690+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:18:10.695+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.695+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:18:10.695+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [true][0m
03-26 00:18:10.700+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:18:10.720+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 681
03-26 00:18:10.735+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.740+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:18:10.745+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.745+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:18:10.750+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:18:10.755+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:10.760+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:18:10.760+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:18:10.765+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:18:10.765+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:18:11.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:12.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:13.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:14.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:15.005+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:16.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:17.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:18.005+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:19.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:19.285+0100 E/PKGMGR  ( 2724): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
03-26 00:18:19.490+0100 E/PKGMGR_SERVER( 2726): pkgmgr-server.c: main(2131) > package manager server start
03-26 00:18:19.580+0100 E/PKGMGR_SERVER( 2726): pkgmgr-server.c: req_cb(650) > req_id=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk_-951555024], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk_-951555024' '-i' '/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk' '-G'], cookie=[aKj/9CAqccYTg6PfpeYfflkv78o=], backend_flag=[0]
03-26 00:18:19.590+0100 E/PKGMGR  ( 2726): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk is core
03-26 00:18:19.595+0100 E/PKGMGR  ( 2724): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[27240002]
03-26 00:18:19.595+0100 E/PKGMGR_SERVER( 2727): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk]
03-26 00:18:19.725+0100 E/rpm-installer( 2727): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk] is tpk package.
03-26 00:18:19.745+0100 E/rpm-installer( 2727): coretpk-parser.c: __coretpk_parser_get_value(1177) > (result_value == NULL) [install-location] is empty.
03-26 00:18:19.745+0100 E/rpm-installer( 2727): coretpk-parser.c: _coretpk_parser_is_custom_clock(974) > (ret == 1) metadata(watchface) is empty.
03-26 00:18:19.750+0100 E/rpm-installer( 2727): coretpk-parser.c: _coretpk_parser_is_widget(1051) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
03-26 00:18:19.750+0100 E/rpm-installer( 2727): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
03-26 00:18:19.835+0100 W/CERT_SVC( 2727): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
03-26 00:18:19.835+0100 E/CERT_SVC( 2727): DUID.cpp: CheckProfileFile(639) > Device profile does not exist in device.
03-26 00:18:19.840+0100 E/CERT_SVC( 2727): cert-service.c: _cert_svc_verify_certificate_with_caflag(184) > Failed to certify device for package.
03-26 00:18:19.840+0100 E/rpm-installer( 2727): rpm-installer.c: _ri_get_visibility_from_signature_file(1849) > cert_svc_verify_package_certificate(-25) failed.
03-26 00:18:19.840+0100 E/rpm-installer( 2727): coretpk-installer.c: _coretpk_installer_get_pkgfile_info(1470) > Couldnt get visiblity [0], ret: -25
03-26 00:18:19.840+0100 E/rpm-installer( 2727): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(3574) > (pkg_file_info == NULL) _coretpk_installer_get_pkgfile_info(/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk) failed.
03-26 00:18:19.845+0100 E/rpm-installer( 2727): rpm-vconf-intf.c: __error_code_for_cert(172) > error=[CERT_SVC_ERR_INVALID_NO_DEVICE_PROFILE]
03-26 00:18:19.845+0100 E/rpm-installer( 2727): rpm-vconf-intf.c: __error_code_for_cert(230) > error_code=[78]
03-26 00:18:19.850+0100 E/rpm-installer( 2727): rpm-cmdline.c: _ri_cmdline_process(500) > __ri_process_request: Error
03-26 00:18:19.865+0100 E/PKGMGR_SERVER( 2726): pkgmgr-server.c: sighandler(407) > child exit [2727] with error code:231
03-26 00:18:19.880+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, STARTED]
03-26 00:18:19.880+0100 E/APPS    (  681): pkgmgr.c: _start(511) >  (_exist_request_in_list(package)) -> _start() return
03-26 00:18:19.880+0100 E/APPS    (  681): pkgmgr.c: _pkgmgr_cb(946) >  pkgmgr_cbs[0].func has errors.
03-26 00:18:19.905+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, FAILED]
03-26 00:18:19.905+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6963) > package [Invalid package] install failed, reason[9078]
03-26 00:18:19.905+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
03-26 00:18:19.905+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
03-26 00:18:19.905+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4841) > triggered from Gear itself.
03-26 00:18:19.905+0100 E/WMS     (  488): wms_db.c: wms_db_package_event_insert_record(178) > 
03-26 00:18:19.925+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2501) > send_install_response completed : END
03-26 00:18:19.935+0100 E/APPS    (  681): pkgmgr.c: _end(883) >  (strcasecmp(val, "ok")) -> _end() return
03-26 00:18:19.935+0100 E/APPS    (  681): pkgmgr.c: _pkgmgr_cb(946) >  pkgmgr_cbs[6].func has errors.
03-26 00:18:19.940+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, COMPLETED]
03-26 00:18:19.940+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
03-26 00:18:19.940+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
03-26 00:18:19.940+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
03-26 00:18:19.940+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4841) > triggered from Gear itself.
03-26 00:18:19.940+0100 E/WMS     (  488): wms_db.c: wms_db_package_event_insert_record(178) > 
03-26 00:18:19.955+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2501) > send_install_response completed : END
03-26 00:18:19.965+0100 E/STARTER (  657): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
03-26 00:18:19.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:20.035+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, COMPLETED]
03-26 00:18:20.035+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
03-26 00:18:20.035+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
03-26 00:18:20.035+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
03-26 00:18:20.035+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4841) > triggered from Gear itself.
03-26 00:18:20.035+0100 E/WMS     (  488): wms_db.c: wms_db_package_event_insert_record(178) > 
03-26 00:18:20.050+0100 E/APPS    (  681): pkgmgr.c: _end(879) >  (!_exist_request_in_list(package)) -> _end() return
03-26 00:18:20.050+0100 E/APPS    (  681): pkgmgr.c: _pkgmgr_cb(946) >  pkgmgr_cbs[6].func has errors.
03-26 00:18:20.055+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2501) > send_install_response completed : END
03-26 00:18:20.065+0100 E/STARTER (  657): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
03-26 00:18:21.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:22.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:22.210+0100 E/PKGMGR_SERVER( 2726): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
03-26 00:18:22.210+0100 E/PKGMGR_SERVER( 2726): pkgmgr-server.c: main(2185) > package manager server terminated.
03-26 00:18:23.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:24.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:25.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:26.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:27.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:28.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:29.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:30.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:31.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:32.000+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:32.220+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
03-26 00:18:32.220+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
03-26 00:18:32.220+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:18:32.240+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
03-26 00:18:32.240+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
03-26 00:18:32.240+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
03-26 00:18:32.240+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
03-26 00:18:32.245+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
03-26 00:18:32.245+0100 W/W_HOME  (  681): dbus.c: _dbus_message_recv_cb(204) > LCD off
03-26 00:18:32.245+0100 W/W_HOME  (  681): gesture.c: _manual_render_disable_timer_del(151) > timer del
03-26 00:18:32.245+0100 W/W_HOME  (  681): gesture.c: _manual_render_enable(133) > 1
03-26 00:18:32.245+0100 W/W_HOME  (  681): event_manager.c: _lcd_off_cb(699) > lcd state: 0
03-26 00:18:32.245+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:18:32.245+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
03-26 00:18:32.245+0100 W/STARTER (  657): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
03-26 00:18:32.245+0100 E/STARTER (  657): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
03-26 00:18:32.245+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
03-26 00:18:32.245+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
03-26 00:18:32.305+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
03-26 00:18:32.305+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:18:32.305+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
03-26 00:18:32.305+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
03-26 00:18:32.410+0100 I/SHealth_Common( 1012): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
03-26 00:18:32.410+0100 I/SHealth_Service( 1012): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
03-26 00:18:32.415+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:780]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
03-26 00:18:32.425+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
03-26 00:18:32.425+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
03-26 00:18:32.425+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
03-26 00:18:32.425+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
03-26 00:18:32.425+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: PAUSE State: RUNNING
03-26 00:18:32.425+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:18:32.425+0100 W/W_HOME  (  681): main.c: _appcore_pause_cb(690) > appcore pause
03-26 00:18:32.425+0100 W/W_HOME  (  681): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
03-26 00:18:32.425+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:18:32.430+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:18:32.430+0100 W/W_HOME  (  681): main.c: home_pause(751) > clock/widget paused
03-26 00:18:32.430+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:18:32.430+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:18:32.430+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:18:32.430+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [false][0m
03-26 00:18:32.435+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
03-26 00:18:32.500+0100 W/WATCH_CORE(  702): appcore-watch.c: __widget_pause(1001) > widget_pause
03-26 00:18:32.935+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:18:37.445+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:18:38.485+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:18:38.485+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:19:38.490+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:19:38.495+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:19:54.280+0100 E/PKGMGR  ( 1211): comm_client_gdbus.c: comm_client_free(283) > Invalid gdbus connection
03-26 00:19:54.280+0100 E/PKGMGR  ( 1211): pkgmgr.c: pkgmgr_client_free(1520) > [0;31m[pkgmgr_client_free(): 1520](ret < 0) comm_client_free() failed[0;m
03-26 00:19:54.285+0100 I/efl-extension( 1211): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:20:38.475+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:20:38.475+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:20:38.475+0100 I/RESOURCED(  492): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
03-26 00:21:38.300+0100 E/PKGMGR  ( 2861): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
03-26 00:21:38.430+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:21:38.430+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:21:38.460+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: main(2131) > package manager server start
03-26 00:21:38.530+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: req_cb(650) > req_id=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk_-752539727], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk_-752539727' '-i' '/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk' '-G'], cookie=[hxWF2HoXj36y1rwyugiHSHDjtm0=], backend_flag=[0]
03-26 00:21:38.535+0100 E/PKGMGR  ( 2867): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk is core
03-26 00:21:38.540+0100 E/PKGMGR  ( 2861): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[28610002]
03-26 00:21:38.540+0100 E/PKGMGR_SERVER( 2869): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk]
03-26 00:21:38.645+0100 E/rpm-installer( 2869): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.basicui-1.0.0-arm.tpk] is tpk package.
03-26 00:21:38.660+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_get_value(1177) > (result_value == NULL) [install-location] is empty.
03-26 00:21:38.665+0100 E/rpm-installer( 2869): coretpk-parser.c: _coretpk_parser_is_custom_clock(974) > (ret == 1) metadata(watchface) is empty.
03-26 00:21:38.665+0100 E/rpm-installer( 2869): coretpk-parser.c: _coretpk_parser_is_widget(1051) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
03-26 00:21:38.665+0100 E/rpm-installer( 2869): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
03-26 00:21:38.795+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, STARTED]
03-26 00:21:38.820+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, PROCESSING]
03-26 00:21:39.035+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_check_ese_metadata(749) > (ret == 1) metadata(watchface) is empty.
03-26 00:21:39.035+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_check_backkey_long_press_metadata(825) > (ret == 1) metadata is empty.
03-26 00:21:39.035+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
03-26 00:21:39.035+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
03-26 00:21:39.035+0100 E/rpm-installer( 2869): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(272) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
03-26 00:21:39.050+0100 E/PKGMGR_PARSER( 2869): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2107) > Manifest is Valid
03-26 00:21:39.055+0100 E/PKGMGR_PARSER( 2869): pkgmgr_parser_signature.c: __ps_check_mdm_policy(977) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
03-26 00:21:39.195+0100 I/PRIVACY-MANAGER-CLIENT( 2869): SocketClient.cpp: SocketClient(37) > Client created
03-26 00:21:39.300+0100 I/efl-extension( 2869): efl_extension.c: eext_mod_init(40) > Init
03-26 00:21:39.300+0100 I/efl-extension( 2869): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:21:39.415+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 18 1
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 19 1
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 20 1
03-26 00:21:39.420+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 1
03-26 00:21:39.435+0100 E/PKGMGR_CERT( 2869): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
03-26 00:21:39.455+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, PROCESSING]
03-26 00:21:39.605+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2153
03-26 00:21:39.660+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1264
03-26 00:21:39.795+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 605
03-26 00:21:40.520+0100 I/AUL_PAD ( 2872): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:21:40.970+0100 I/efl-extension( 2873): efl_extension.c: eext_mod_init(40) > Init
03-26 00:21:41.010+0100 I/UXT     ( 2873): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:21:41.095+0100 E/rpm-installer( 2869): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
03-26 00:21:41.115+0100 I/AUL_PAD ( 2873): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:21:41.145+0100 E/TBM     ( 2873): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:21:41.210+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
03-26 00:21:41.665+0100 W/MM_CAMCORDER( 2874): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
03-26 00:21:41.665+0100 W/MM_CAMCORDER( 2874): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
03-26 00:21:41.665+0100 I/efl-extension( 2874): efl_extension.c: eext_mod_init(40) > Init
03-26 00:21:42.785+0100 I/AUL     ( 2874): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
03-26 00:21:42.800+0100 I/AUL     ( 2874): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
03-26 00:21:42.800+0100 E/AUL     ( 2874): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
03-26 00:21:42.800+0100 E/AUL     ( 2874): aul_path.c: __get_path(169) > root_path is NULL!
03-26 00:21:42.855+0100 I/AUL     ( 2874): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
03-26 00:21:42.880+0100 I/AUL     ( 2874): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
03-26 00:21:42.880+0100 E/AUL     ( 2874): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
03-26 00:21:42.880+0100 E/AUL     ( 2874): aul_path.c: __get_path(169) > root_path is NULL!
03-26 00:21:42.935+0100 I/UXT     ( 2874): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:21:43.125+0100 E/TBM     ( 2874): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:21:43.210+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
03-26 00:21:44.430+0100 E/rpm-installer( 2869): coretpk-installer.c: __post_install_for_mmc(426) > (handle == NULL) handle is NULL.
03-26 00:21:44.455+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, PROCESSING]
03-26 00:21:44.480+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_log_package(4560) > package [_________] callback : [INSTALL, COMPLETED]
03-26 00:21:44.480+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6943) > package install complete
03-26 00:21:44.480+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4815) > 
03-26 00:21:44.480+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1762) > Found in install_req_list?[0], index[-1]
03-26 00:21:44.480+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_package_install_event(4841) > triggered from Gear itself.
03-26 00:21:44.480+0100 E/WMS     (  488): wms_db.c: wms_db_package_event_insert_record(178) > 
03-26 00:21:44.490+0100 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2501) > send_install_response completed : END
03-26 00:21:44.560+0100 E/PKGMGR_INFO(  485): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-26 00:21:44.565+0100 E/STARTER (  657): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
03-26 00:21:44.670+0100 E/Vi::Animations(  681): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
03-26 00:21:44.670+0100 I/Vi::Animations(  681): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
03-26 00:21:44.675+0100 E/EFL     (  681): elementary<681> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x477ab6e0 into part 'elm.swallow.event.0'
03-26 00:21:44.680+0100 E/APPS    (  681): AppsViewNecklace.cpp: onShow(570) >  AppsItemList[23]
03-26 00:21:45.210+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
03-26 00:21:45.240+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2869]
03-26 00:21:47.210+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
03-26 00:21:47.210+0100 E/PKGMGR_SERVER( 2867): pkgmgr-server.c: main(2185) > package manager server terminated.
03-26 00:22:03.370+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:03.385+0100 I/AUL_AMD (  491): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
03-26 00:22:03.395+0100 I/AUL_AMD (  491): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
03-26 00:22:03.395+0100 E/AUL_AMD (  491): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
03-26 00:22:03.395+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 2952
03-26 00:22:03.410+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:03.410+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:22:03.410+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:03.410+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:03.410+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:03.455+0100 I/efl-extension( 2872): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:03.455+0100 I/UXT     ( 2872): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:03.460+0100 I/CAPI_APPFW_APPLICATION( 2872): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:03.465+0100 I/CAPI_APPFW_APPLICATION( 2872): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:03.520+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:03.525+0100 E/TBM     ( 2872): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:03.575+0100 E/EFL     ( 2872): ecore_evas<2872> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:03.950+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1102872626173145894812
