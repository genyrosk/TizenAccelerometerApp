S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 4985
Date: 2016-03-23 18:46:23+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb45c7106

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000012, esi = 0x00000000
ebp = 0xbfa08158, esp = 0xbfa07f58
eax = 0xb45c7106, ebx = 0xb7619ff4
ecx = 0x00000032, edx = 0xbfa0871c
eip = 0xb74ed3c0

Memory Information
MemTotal:      124 KB
MemFree:        27 KB
Buffers:        14 KB
Cached:     139528 KB
VmPeak:      72372 KB
VmSize:      72372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14648 KB
VmRSS:       14648 KB
VmData:      12368 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31800 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4985 TID = 4985
4985 4989 

Maps Information
b35a7000 b35a8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b35a9000 b35ab000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b35ac000 b35d0000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3772000 b3775000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3776000 b3784000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3785000 b3794000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f9b000 b3f9e000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f9f000 b3fa2000 r-xp /usr/lib/libdri2.so.0.0.0
b3fa3000 b3fae000 r-xp /usr/lib/libdrm.so.2.4.0
b3faf000 b3fb8000 r-xp /usr/lib/libtbm.so.1.0.0
b3fb9000 b3fc0000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3fc1000 b3fca000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3fcb000 b3fd2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fd3000 b3fd9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fda000 b3fe2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fe3000 b3fe7000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3fe8000 b4005000 r-xp /usr/lib/libtts.so
b4006000 b414a000 r-xp /usr/lib/libcairo.so.2.11200.14
b414e000 b4166000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4167000 b4188000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4189000 b4199000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b419a000 b41a5000 r-xp /lib/libnss_files-2.13.so
b43e6000 b440d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b440e000 b4433000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4434000 b4555000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4565000 b459b000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b459d000 b45a0000 r-xp /usr/lib/libiniparser.so.0
b45a2000 b45ac000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45ad000 b45b6000 r-xp /usr/lib/libappsvc.so.0.1.0
b45b7000 b45ba000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45bb000 b45bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45be000 b45c4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b45c5000 b45c8000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b45c9000 b45cf000 r-xp /usr/lib/libogg.so.0.7.1
b45d0000 b45fb000 r-xp /usr/lib/libvorbis.so.0.4.3
b45fc000 b46e7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46f5000 b46f7000 r-xp /usr/lib/libXau.so.6.0.0
b46f8000 b4758000 r-xp /usr/lib/libssl.so.1.0.0
b475d000 b478e000 r-xp /usr/lib/libidn.so.11.5.44
b478f000 b479f000 r-xp /usr/lib/libcares.so.2.1.0
b47a0000 b4809000 r-xp /usr/lib/libsndfile.so.1.0.25
b480f000 b4819000 r-xp /usr/lib/libsensord-share.so
b481a000 b4840000 r-xp /lib/libexpat.so.1.5.2
b4842000 b4869000 r-xp /usr/lib/libpng12.so.0.50.0
b486a000 b488a000 r-xp /usr/lib/libxcb.so.1.1.0
b488b000 b48fa000 r-xp /usr/lib/libcurl.so.4.3.0
b48fc000 b4907000 r-xp /usr/lib/libethumb.so.1.7.99
b5e67000 b5f3f000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f4b000 b5f4e000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f4f000 b5f65000 r-xp /usr/lib/libremix.so.0.0.0
b5f66000 b5f68000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f69000 b5f95000 r-xp /usr/lib/liblua-5.1.so
b5f96000 b5fa0000 r-xp /usr/lib/libembryo.so.1.7.99
b5fa1000 b5fe7000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ff8000 b6016000 r-xp /usr/lib/libsensor.so.1.1.0
b6018000 b609a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b609f000 b60d3000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60d5000 b6130000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6132000 b6148000 r-xp /usr/lib/libfribidi.so.0.3.1
b6149000 b61d5000 r-xp /usr/lib/libfreetype.so.6.11.3
b61d9000 b61dc000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61dd000 b61e3000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61e4000 b61ea000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61ec000 b61fd000 r-xp /usr/lib/libXext.so.6.4.0
b61fe000 b6332000 r-xp /usr/lib/libX11.so.6.3.0
b6336000 b633b000 r-xp /usr/lib/libXtst.so.6.1.0
b633c000 b6344000 r-xp /usr/lib/libXrender.so.1.3.0
b6345000 b634e000 r-xp /usr/lib/libXrandr.so.2.2.0
b634f000 b6351000 r-xp /usr/lib/libXinerama.so.1.0.0
b6352000 b6360000 r-xp /usr/lib/libXi.so.6.1.0
b6361000 b6365000 r-xp /usr/lib/libXfixes.so.3.1.0
b6366000 b6368000 r-xp /usr/lib/libXgesture.so.7.0.0
b6369000 b636b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b636c000 b636e000 r-xp /usr/lib/libXdamage.so.1.1.0
b636f000 b6378000 r-xp /usr/lib/libXcursor.so.1.0.2
b6379000 b63a4000 r-xp /usr/lib/libecore_con.so.1.7.99
b63a6000 b63ae000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63af000 b63ba000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63bb000 b63c1000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63c2000 b63e3000 r-xp /usr/lib/libefreet.so.1.7.99
b63e5000 b63f1000 r-xp /usr/lib/libedbus.so.1.7.99
b63f2000 b6551000 r-xp /usr/lib/libicuuc.so.51.1
b655f000 b6768000 r-xp /usr/lib/libicui18n.so.51.1
b6771000 b680e000 r-xp /usr/lib/libedje.so.1.7.99
b6810000 b6821000 r-xp /usr/lib/libecore_input.so.1.7.99
b6822000 b6829000 r-xp /usr/lib/libecore_file.so.1.7.99
b682a000 b6850000 r-xp /usr/lib/libeet.so.1.7.99
b6859000 b6981000 r-xp /usr/lib/libevas.so.1.7.99
b699e000 b69d1000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69d3000 b6a17000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a19000 b6c13000 r-xp /usr/lib/libelementary.so.1.7.99
b6c24000 b6c2a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c2b000 b6c2f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c33000 b6c34000 r-xp /usr/lib/libjournal.so.0.1.0
b6c35000 b6d7d000 r-xp /usr/lib/libxml2.so.2.7.8
b6d84000 b6d97000 r-xp /lib/libresolv-2.13.so
b6d9b000 b6db8000 r-xp /lib/libz.so.1.2.5
b6db9000 b6dbc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6dbd000 b6dc2000 r-xp /usr/lib/libffi.so.5.0.10
b6dc3000 b6dc4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dc6000 b6dca000 r-xp /lib/libattr.so.1.1.0
b6dcb000 b6fdd000 r-xp /usr/lib/libcrypto.so.1.0.0
b6ff8000 b7019000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b701a000 b7042000 r-xp /lib/libm-2.13.so
b7044000 b709f000 r-xp /usr/lib/libeina.so.1.7.99
b70a2000 b70ad000 r-xp /usr/lib/libvconf.so.0.2.45
b70ae000 b70b1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70b2000 b7100000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7101000 b7262000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7266000 b726d000 r-xp /lib/librt-2.13.so
b7270000 b7277000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7279000 b7293000 r-xp /lib/libgcc_s-4.6.4.so.1
b7294000 b729c000 r-xp /lib/libcrypt-2.13.so
b72c5000 b72c9000 r-xp /lib/libcap.so.2.21
b72ca000 b72cc000 r-xp /usr/lib/libiri.so
b72ce000 b72fa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72fb000 b731b000 r-xp /usr/lib/libecore.so.1.7.99
b732a000 b7333000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7334000 b7457000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7458000 b746b000 r-xp /usr/lib/libail.so.0.1.0
b746d000 b7492000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7493000 b749d000 r-xp /lib/libunwind.so.8.0.1
b74a7000 b7618000 r-xp /lib/libc-2.13.so
b761e000 b7668000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7669000 b766e000 r-xp /usr/lib/libbundle.so.0.1.22
b766f000 b7672000 r-xp /lib/libdl-2.13.so
b7675000 b767a000 r-xp /usr/lib/libsmack.so.1.0.0
b767b000 b7723000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7726000 b7740000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7741000 b7758000 r-xp /lib/libpthread-2.13.so
b775c000 b775f000 r-xp /usr/lib/libdlog.so.0.0.0
b7760000 b7770000 r-xp /usr/lib/libaul.so.0.1.0
b7772000 b7778000 r-xp /usr/lib/libappcore-common.so.1.1
b7779000 b777e000 r-xp /usr/lib/libappcore-efl.so.1.1
b7780000 b7785000 r-xp /usr/lib/libsys-assert.so
b7788000 b77a6000 r-xp /lib/ld-2.13.so
b77a6000 b77a7000 r-xp [vdso]
b77a9000 b77b0000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4985)
Call Stack Count: 17
 0: __printf_fp + 0x16a0 (0xb74ed3c0) [/lib/libc.so.6] + 0x463c0
 1: _IO_vfprintf + 0x48e5 (0xb74eb345) [/lib/libc.so.6] + 0x44345
 2: vsprintf + 0xa4 (0xb7506d24) [/lib/libc.so.6] + 0x5fd24
 3: (0xb45c1766) [/usr/lib/libcapi-system-sensor.so.0] + 0x3766
 4: (0xb60088b6) [/usr/lib/libsensor.so.1] + 0x108b6
 5: (0xb7377841) [/usr/lib/libglib-2.0.so.0] + 0x43841
 6: g_main_context_dispatch + 0x133 (0xb7379dd3) [/usr/lib/libglib-2.0.so.0] + 0x45dd3
 7: (0xb730fd40) [/usr/lib/libecore.so.1] + 0x14d40
 8: (0xb730896f) [/usr/lib/libecore.so.1] + 0xd96f
 9: (0xb7309654) [/usr/lib/libecore.so.1] + 0xe654
10: ecore_main_loop_begin + 0x3f (0xb73099cf) [/usr/lib/libecore.so.1] + 0xe9cf
11: elm_run + 0x17 (0xb6b208a7) [/usr/lib/libelementary.so.1] + 0x1078a7
12: appcore_efl_main + 0x3d1 (0xb777be91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
13: ui_app_main + 0x130 (0xb6c2d5f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
14: main + 0x30d (0xb45c63ad) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x13ad
15: (0xb77ac5b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77ac5b1
16: __libc_start_main + 0xf3 (0xb74c00f3) [/lib/libc.so.6] + 0x190f3
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
> __trm_app_info_send_socket
03-23 18:46:17.322+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 4937, type 4 
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 4937
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-23 18:46:17.322+0900 E/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 248
03-23 18:46:17.322+0900 D/RESOURCED( 2337): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-23 18:46:17.322+0900 D/AUL     ( 2241): launch.c: app_request_to_launchpad(295) > launch request result : 4937
03-23 18:46:17.322+0900 D/W_HOME  ( 2241): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-23 18:46:17.322+0900 D/LAUNCH  ( 2241): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-23 18:46:17.322+0900 E/W_HOME  ( 2241): main.c: _window_focus_out_cb(885) > win[25165827], ev->win[25165831]
03-23 18:46:17.322+0900 D/APPS    ( 2241): apps_main.c: _window_focus_out_cb(308) >  focus out
03-23 18:46:17.322+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:46:17.322+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(656) >  Pause starts
03-23 18:46:17.322+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(676) >  Pause done
03-23 18:46:17.322+0900 W/APPS    ( 2241): item.c: _anim_item_released_cb(1075) >  item is released
03-23 18:46:17.322+0900 D/APPS    ( 2241): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-23 18:46:17.382+0900 D/APP_CORE( 4937): appcore.c: __prt_ltime(183) > [APP 4937] first idle after reset: 166 msec
03-23 18:46:17.382+0900 D/APP_CORE( 4937): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
03-23 18:46:17.382+0900 D/APP_CORE( 4937): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800007 fully_obscured 1
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(470) > [APP 2241] Event: PAUSE State: RUNNING
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(538) > [APP 2241] PAUSE
03-23 18:46:17.402+0900 I/CAPI_APPFW_APPLICATION( 2241): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-23 18:46:17.402+0900 D/W_HOME  ( 2241): main.c: _pause_cb(600) > Paused
03-23 18:46:17.402+0900 E/W_HOME  ( 2241): main.c: _pause_cb(603) > paused already
03-23 18:46:17.402+0900 D/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:17.402+0900 E/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:17.402+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2241, type = 2
03-23 18:46:17.402+0900 D/AUL_AMD ( 2167): amd_launch.c: __e17_status_handler(1911) > pid(4937) status(3)
03-23 18:46:17.402+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4937, type = 0
03-23 18:46:17.402+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4937
03-23 18:46:17.402+0900 I/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4937, oom : 200
03-23 18:46:17.402+0900 E/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-23 18:46:17.452+0900 D/APP_CORE( 4937): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
03-23 18:46:17.452+0900 D/APP_CORE( 4937): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-23 18:46:17.452+0900 D/APP_CORE( 4937): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-23 18:46:17.452+0900 D/APP_CORE( 4937): appcore-efl.c: __do_app(470) > [APP 4937] Event: RESUME State: RUNNING
03-23 18:46:17.452+0900 D/LAUNCH  ( 4937): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
03-23 18:46:17.452+0900 D/LAUNCH  ( 4937): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
03-23 18:46:17.452+0900 D/LAUNCH  ( 4937): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
03-23 18:46:17.452+0900 D/APP_CORE( 4937): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:17.452+0900 E/APP_CORE( 4937): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:18.172+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(113) > pid(4599)
03-23 18:46:18.172+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-23 18:46:18.242+0900 I/GESTURE ( 2052): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-23 18:46:18.282+0900 W/CRASH_MANAGER( 4751): worker.c: worker_job(1189) > 11049376261731458726378
03-23 18:46:18.322+0900 D/AUL_AMD ( 2167): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-23 18:46:18.322+0900 D/RUA     ( 2167): rua.c: rua_add_history(179) > rua_add_history start
03-23 18:46:18.332+0900 D/RUA     ( 2167): rua.c: rua_add_history(247) > rua_add_history ok
03-23 18:46:18.332+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2241, type = 0
03-23 18:46:18.332+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2241
03-23 18:46:18.332+0900 E/RESOURCED( 2337): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2241) didn't have any process list
03-23 18:46:18.332+0900 D/RESOURCED( 2337): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2241, appname = (null)
03-23 18:46:18.332+0900 D/RESOURCED( 2337): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2241
03-23 18:46:18.332+0900 D/AUL_AMD ( 2167): amd_launch.c: __e17_status_handler(1911) > pid(2241) status(3)
03-23 18:46:18.332+0900 I/AUL_PAD ( 2189): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4937 pgid = 4937
03-23 18:46:18.332+0900 I/AUL_PAD ( 2189): sigchild.h: __sigchild_action(123) > dead_pid(4937)
03-23 18:46:18.332+0900 D/AUL_PAD ( 2189): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-23 18:46:18.332+0900 I/AUL_PAD ( 2189): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-23 18:46:18.332+0900 I/AUL_PAD ( 2189): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-23 18:46:18.332+0900 I/AUL_AMD ( 2167): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4937
03-23 18:46:18.332+0900 D/AUL_AMD ( 2167): amd_key.c: _unregister_key_event(161) > ===key stack===
03-23 18:46:18.332+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-23 18:46:18.332+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:46:18.332+0900 D/STARTER ( 2234): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4937)
03-23 18:46:18.412+0900 D/EFL     ( 2241): ecore_x<2241> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=23729365 button=1
03-23 18:46:18.412+0900 E/W_HOME  ( 2241): main.c: _window_focus_in_cb(851) > win[25165827], ev->win[25165831]
03-23 18:46:18.412+0900 D/APPS    ( 2241): apps_main.c: _window_focus_in_cb(288) >  focus in
03-23 18:46:18.412+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:46:18.412+0900 D/APPS    ( 2241): apps_main.c: apps_main_resume(693) >  Resume starts
03-23 18:46:18.412+0900 D/APPS    ( 2241): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-23 18:46:18.412+0900 E/efl-extension( 2241): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7b8bfb0, elm_scroller, _activated_obj : 0xb7b8bfb0, activated : 1
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800007 fully_obscured 0
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(470) > [APP 2241] Event: RESUME State: PAUSED
03-23 18:46:18.412+0900 D/LAUNCH  ( 2241): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(559) > [APP 2241] RESUME
03-23 18:46:18.412+0900 I/CAPI_APPFW_APPLICATION( 2241): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-23 18:46:18.412+0900 D/W_HOME  ( 2241): main.c: _resume_cb(564) > Resumed
03-23 18:46:18.412+0900 D/APPS    ( 2241): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
03-23 18:46:18.412+0900 E/W_HOME  ( 2241): main.c: _resume_cb(576) > Apps is showing
03-23 18:46:18.412+0900 D/LAUNCH  ( 2241): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
03-23 18:46:18.412+0900 D/LAUNCH  ( 2241): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
03-23 18:46:18.412+0900 D/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:18.412+0900 E/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:18.412+0900 D/W_HOME  ( 2241): main.c: _dead_cb(542) > PID(4937) is dead
03-23 18:46:18.412+0900 E/W_HOME  ( 2241): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.462+0900 D/PKGMGR_INFO( 4751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.582+0900 D/AUL     ( 4959): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
03-23 18:46:19.582+0900 D/AUL     ( 4959): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-23 18:46:19.582+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 0
03-23 18:46:19.582+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
03-23 18:46:19.582+0900 D/AUL     ( 2167): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2111, pid = 4959
03-23 18:46:19.592+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-23 18:46:19.592+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1785) > process_pool: false
03-23 18:46:19.592+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-23 18:46:19.592+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
03-23 18:46:19.592+0900 D/AUL_AMD ( 2167): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-23 18:46:19.592+0900 D/AUL     ( 2167): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-23 18:46:19.592+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
03-23 18:46:19.592+0900 D/AUL_PAD ( 2189): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-23 18:46:19.592+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4960 /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-23 18:46:19.592+0900 D/AUL_PAD ( 2189): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-23 18:46:19.592+0900 D/AUL_PAD ( 4960): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-23 18:46:19.592+0900 D/AUL_PAD ( 4960): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-23 18:46:19.592+0900 D/AUL_PAD ( 4960): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
03-23 18:46:19.592+0900 D/AUL_PAD ( 4960): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
03-23 18:46:19.602+0900 D/AUL_PAD ( 4960): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
03-23 18:46:19.602+0900 D/LAUNCH  ( 4960): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
03-23 18:46:19.622+0900 D/LAUNCH  ( 4960): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
03-23 18:46:19.622+0900 D/APP_CORE( 4960): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-23 18:46:19.632+0900 D/AUL     ( 4960): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4960 is org.tizen.crash-popup
03-23 18:46:19.632+0900 D/APP_CORE( 4960): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
03-23 18:46:19.632+0900 D/APP_CORE( 4960): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-23 18:46:19.632+0900 D/AUL     ( 4960): app_sock.c: __create_server_sock(136) > pg path - already exists
03-23 18:46:19.632+0900 D/LAUNCH  ( 4960): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
03-23 18:46:19.642+0900 D/EFL-ASSIST( 4960): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
03-23 18:46:19.642+0900 D/EFL-ASSIST( 4960): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
03-23 18:46:19.642+0900 I/EFL-ASSIST( 4960): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b7990760]
03-23 18:46:19.652+0900 D/EFL-ASSIST( 4960): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
03-23 18:46:19.652+0900 I/EFL-ASSIST( 4960): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
03-23 18:46:19.652+0900 I/EFL-ASSIST( 4960): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b798bbc8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
03-23 18:46:19.652+0900 I/EFL-ASSIST( 4960): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b798bbc8) is freed
03-23 18:46:19.652+0900 I/EFL-ASSIST( 4960): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
03-23 18:46:19.652+0900 I/EFL-ASSIST( 4960): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
03-23 18:46:19.652+0900 D/APP_CORE( 4960): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-23 18:46:19.652+0900 D/LAUNCH  ( 4960): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
03-23 18:46:19.652+0900 D/APP_CORE( 4960): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-23 18:46:19.652+0900 D/APP_CORE( 4960): appcore.c: __aul_handler(423) > [APP 4960]     AUL event: AUL_START
03-23 18:46:19.652+0900 D/APP_CORE( 4960): appcore-efl.c: __do_app(470) > [APP 4960] Event: RESET State: CREATED
03-23 18:46:19.652+0900 D/APP_CORE( 4960): appcore-efl.c: __do_app(496) > [APP 4960] RESET
03-23 18:46:19.652+0900 D/LAUNCH  ( 4960): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
03-23 18:46:19.662+0900 D/CRASH_POPUP( 4960): crash.c: app_reset(226) > bundle_get_val - process_name:basicui
03-23 18:46:19.662+0900 D/CRASH_POPUP( 4960): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.example.basicui/bin/basicui
03-23 18:46:19.662+0900 D/PKGMGR_INFO( 4960): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.662+0900 D/PKGMGR_INFO( 4960): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.662+0900 D/PKGMGR_INFO( 4960): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.662+0900 D/PKGMGR_INFO( 4960): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-23 18:46:19.662+0900 I/CRASH_POPUP( 4960): crash.c: load_crash_process_popup(117) > Popup content: basicui has closed unexpectedly.
03-23 18:46:19.682+0900 E/W_HOME  ( 2241): main.c: _window_focus_out_cb(885) > win[25165827], ev->win[25165831]
03-23 18:46:19.682+0900 D/APPS    ( 2241): apps_main.c: _window_focus_out_cb(308) >  focus out
03-23 18:46:19.682+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:46:19.682+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(656) >  Pause starts
03-23 18:46:19.682+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(676) >  Pause done
03-23 18:46:19.682+0900 E/EFL     ( 4960): eina_module<4960> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-23 18:46:19.692+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-23 18:46:19.692+0900 D/AUL_PAD ( 2189): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-23 18:46:19.692+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-23 18:46:19.692+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-23 18:46:19.692+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 4960, type 4 
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 4960
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
03-23 18:46:19.692+0900 E/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 248
03-23 18:46:19.692+0900 D/RESOURCED( 2337): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-23 18:46:19.692+0900 D/AUL     ( 4959): launch.c: app_request_to_launchpad(295) > launch request result : 4960
03-23 18:46:19.732+0900 D/LAUNCH  ( 4960): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
03-23 18:46:19.732+0900 I/APP_CORE( 4960): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-23 18:46:19.732+0900 I/APP_CORE( 4960): appcore-efl.c: __do_app(509) > [APP 4960] Initial Launching, call the resume_cb
03-23 18:46:19.732+0900 D/APP_CORE( 4960): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-23 18:46:19.742+0900 D/APP_CORE( 4960): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00006
03-23 18:46:19.742+0900 D/APP_CORE( 4960): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00006
03-23 18:46:19.782+0900 I/GESTURE ( 2052): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-23 18:46:19.812+0900 D/AUL_AMD ( 2167): amd_launch.c: __e17_status_handler(1911) > pid(4960) status(3)
03-23 18:46:19.812+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4960, type = 0
03-23 18:46:19.812+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4960
03-23 18:46:19.812+0900 I/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4960, oom : 200
03-23 18:46:19.812+0900 E/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-23 18:46:19.812+0900 E/RESOURCED( 2337): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (4960) didn't have any process list
03-23 18:46:19.812+0900 D/RESOURCED( 2337): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 4960, appname = (null)
03-23 18:46:19.812+0900 D/RESOURCED( 2337): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4960
03-23 18:46:19.892+0900 D/EFL     ( 4960): ecore_x<4960> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=23730847 button=1
03-23 18:46:19.892+0900 D/APP_CORE( 4960): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00006 fully_obscured 0
03-23 18:46:19.892+0900 D/APP_CORE( 4960): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-23 18:46:19.892+0900 D/APP_CORE( 4960): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-23 18:46:19.902+0900 D/APP_CORE( 4960): appcore-efl.c: __do_app(470) > [APP 4960] Event: RESUME State: RUNNING
03-23 18:46:19.902+0900 D/LAUNCH  ( 4960): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
03-23 18:46:19.902+0900 D/LAUNCH  ( 4960): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
03-23 18:46:19.902+0900 D/LAUNCH  ( 4960): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
03-23 18:46:19.902+0900 D/APP_CORE( 4960): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:19.902+0900 E/APP_CORE( 4960): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:20.032+0900 D/EFL     ( 4960): ecore_x<4960> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=23730936 button=1
03-23 18:46:20.032+0900 D/APP_CORE( 4960): appcore.c: __prt_ltime(183) > [APP 4960] first idle after reset: 445 msec
03-23 18:46:20.692+0900 D/AUL_AMD ( 2167): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-23 18:46:20.692+0900 D/RUA     ( 2167): rua.c: rua_add_history(179) > rua_add_history start
03-23 18:46:20.702+0900 D/RUA     ( 2167): rua.c: rua_add_history(247) > rua_add_history ok
03-23 18:46:20.892+0900 I/GESTURE ( 2052): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-23 18:46:20.942+0900 D/EFL     ( 4960): ecore_x<4960> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=23731944 button=1
03-23 18:46:21.042+0900 D/EFL     ( 4960): ecore_x<4960> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=23732022 button=1
03-23 18:46:21.042+0900 E/EFL     ( 4960): eina_module<4960> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-23 18:46:21.372+0900 D/AUL     ( 4960): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-23 18:46:21.372+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 22
03-23 18:46:21.382+0900 D/APP_CORE( 4960): appcore-efl.c: __after_loop(1062) > [APP 4960] PAUSE before termination
03-23 18:46:21.382+0900 E/W_HOME  ( 2241): main.c: _window_focus_in_cb(851) > win[25165827], ev->win[25165831]
03-23 18:46:21.382+0900 D/APPS    ( 2241): apps_main.c: _window_focus_in_cb(288) >  focus in
03-23 18:46:21.382+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:46:21.382+0900 D/APPS    ( 2241): apps_main.c: apps_main_resume(693) >  Resume starts
03-23 18:46:21.382+0900 D/APPS    ( 2241): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-23 18:46:21.382+0900 E/efl-extension( 2241): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb7b8bfb0, elm_scroller, _activated_obj : 0xb7b8bfb0, activated : 1
03-23 18:46:21.422+0900 I/AUL_PAD ( 2189): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4960 pgid = 4960
03-23 18:46:21.422+0900 I/AUL_PAD ( 2189): sigchild.h: __sigchild_action(123) > dead_pid(4960)
03-23 18:46:21.422+0900 D/AUL_PAD ( 2189): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-23 18:46:21.422+0900 I/AUL_PAD ( 2189): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-23 18:46:21.422+0900 I/AUL_PAD ( 2189): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-23 18:46:21.422+0900 D/W_HOME  ( 2241): main.c: _dead_cb(542) > PID(4960) is dead
03-23 18:46:21.422+0900 E/W_HOME  ( 2241): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-23 18:46:21.422+0900 D/STARTER ( 2234): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4960)
03-23 18:46:21.422+0900 I/AUL_AMD ( 2167): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4960
03-23 18:46:21.422+0900 D/AUL_AMD ( 2167): amd_key.c: _unregister_key_event(161) > ===key stack===
03-23 18:46:21.422+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-23 18:46:21.422+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:46:22.202+0900 I/GESTURE ( 2052): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-23 18:46:22.252+0900 D/EFL     ( 2241): ecore_x<2241> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=23733216 button=1
03-23 18:46:22.252+0900 D/APPS    ( 2241): scroller.c: _mouse_down_cb(100) >  Mouse is down [163,188]
03-23 18:46:22.252+0900 D/APPS    ( 2241): item.c: _down_cb(381) >  Down (basicui,0xb7b8e510) (163, 188), item pos(41,1,280,390)
03-23 18:46:22.252+0900 E/APPS    ( 2241): item.c: _down_cb(425) >  longpress edit mode disable
03-23 18:46:22.272+0900 W/APPS    ( 2241): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-23 18:46:22.342+0900 D/EFL     ( 2241): ecore_x<2241> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=23733353 button=1
03-23 18:46:22.342+0900 D/APPS    ( 2241): scroller.c: _mouse_up_cb(111) >  Mouse is up [163,188]
03-23 18:46:22.342+0900 D/APPS    ( 2241): item.c: _up_cb(573) >  Up (basicui,0xb7b8e510) (163, 188), item pos(41,1,280,390)
03-23 18:46:22.342+0900 E/APPS    ( 2241): item.c: _clicked_cb(65) >  Clicked
03-23 18:46:22.342+0900 E/APPS    ( 2241): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-23 18:46:22.342+0900 D/APPS    ( 2241): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-23 18:46:22.342+0900 D/APP_SVC ( 2241): appsvc.c: __set_bundle(161) > __set_bundle
03-23 18:46:22.342+0900 D/APP_SVC ( 2241): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-23 18:46:22.342+0900 D/APP_SVC ( 2241): appsvc.c: __set_bundle(161) > __set_bundle
03-23 18:46:22.342+0900 D/W_HOME  ( 2241): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-23 18:46:22.342+0900 D/W_HOME  ( 2241): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-23 18:46:22.342+0900 D/APP_SVC ( 2241): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-23 18:46:22.342+0900 D/AUL     ( 2241): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-23 18:46:22.342+0900 D/AUL     ( 2241): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 0
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-23 18:46:22.342+0900 E/AUL_AMD ( 2167): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1785) > process_pool: false
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-23 18:46:22.342+0900 D/AUL_AMD ( 2167): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-23 18:46:22.342+0900 D/AUL     ( 2167): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-23 18:46:22.342+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-23 18:46:22.342+0900 D/AUL_PAD ( 2189): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-23 18:46:22.342+0900 D/AUL_PAD ( 2189): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4985 /opt/usr/apps/org.example.basicui/bin/basicui
03-23 18:46:22.342+0900 D/AUL_PAD ( 2189): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-23 18:46:22.352+0900 D/AUL_PAD ( 4985): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-23 18:46:22.352+0900 D/LAUNCH  ( 4985): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-23 18:46:22.362+0900 I/efl-extension( 4985): efl_extension.c: eext_mod_init(39) > Init
03-23 18:46:22.362+0900 I/CAPI_APPFW_APPLICATION( 4985): app_main.c: ui_app_main(701) > app_efl_main
03-23 18:46:22.362+0900 D/LAUNCH  ( 4985): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-23 18:46:22.392+0900 D/APP_CORE( 4985): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-23 18:46:22.392+0900 D/AUL     ( 4985): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4985 is org.example.basicui
03-23 18:46:22.392+0900 D/APP_CORE( 4985): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-23 18:46:22.392+0900 D/APP_CORE( 4985): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-23 18:46:22.392+0900 D/AUL     ( 4985): app_sock.c: __create_server_sock(136) > pg path - already exists
03-23 18:46:22.392+0900 D/LAUNCH  ( 4985): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-23 18:46:22.392+0900 I/CAPI_APPFW_APPLICATION( 4985): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-23 18:46:22.412+0900 E/EFL     ( 4985): eina_module<4985> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-23 18:46:22.422+0900 E/EFL     ( 4985): ecore_evas<4985> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-23 18:46:22.432+0900 E/EFL     ( 4985): elementary<4985> elc_naviframe.c:46 _nf_mod_init() _nf_mod_init initted 1
03-23 18:46:22.432+0900 E/EFL     ( 4985): eina_module<4985> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
03-23 18:46:22.442+0900 I/basicui ( 4985): started
03-23 18:46:22.442+0900 I/basicui ( 4985): listener
03-23 18:46:22.442+0900 D/LAUNCH  ( 4985): appcore-efl.c: __before_loop(1047) > [basicui:Application:create:done]
03-23 18:46:22.442+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-23 18:46:22.442+0900 D/AUL_PAD ( 2189): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-23 18:46:22.442+0900 D/AUL_PAD ( 2189): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-23 18:46:22.442+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-23 18:46:22.442+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 4985, type 4 
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 4985
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-23 18:46:22.442+0900 E/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 248
03-23 18:46:22.442+0900 D/RESOURCED( 2337): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-23 18:46:22.442+0900 D/AUL     ( 2241): launch.c: app_request_to_launchpad(295) > launch request result : 4985
03-23 18:46:22.442+0900 D/W_HOME  ( 2241): util.c: apps_util_launch_main_operation(686) > [SECURE_LOG] Launch an app(org.example.basicui:basicui) ret : [0]
03-23 18:46:22.442+0900 D/LAUNCH  ( 2241): util.c: apps_util_launch_main_operation(687) > [SECURE_LOG] [org.example.basicui:Menuscreen:launch:done]
03-23 18:46:22.452+0900 W/APPS    ( 2241): item.c: _anim_item_released_cb(1075) >  item is released
03-23 18:46:22.452+0900 D/APPS    ( 2241): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-23 18:46:22.452+0900 D/APP_CORE( 4985): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-23 18:46:22.452+0900 D/APP_CORE( 4985): appcore.c: __aul_handler(423) > [APP 4985]     AUL event: AUL_START
03-23 18:46:22.452+0900 D/APP_CORE( 4985): appcore-efl.c: __do_app(470) > [APP 4985] Event: RESET State: CREATED
03-23 18:46:22.452+0900 D/APP_CORE( 4985): appcore-efl.c: __do_app(496) > [APP 4985] RESET
03-23 18:46:22.452+0900 D/LAUNCH  ( 4985): appcore-efl.c: __do_app(498) > [basicui:Application:reset:start]
03-23 18:46:22.452+0900 I/CAPI_APPFW_APPLICATION( 4985): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
03-23 18:46:22.452+0900 D/LAUNCH  ( 4985): appcore-efl.c: __do_app(501) > [basicui:Application:reset:done]
03-23 18:46:22.452+0900 I/APP_CORE( 4985): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-23 18:46:22.452+0900 I/APP_CORE( 4985): appcore-efl.c: __do_app(509) > [APP 4985] Initial Launching, call the resume_cb
03-23 18:46:22.452+0900 I/CAPI_APPFW_APPLICATION( 4985): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-23 18:46:22.452+0900 D/APP_CORE( 4985): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : org.tizen.w-home
03-23 18:46:22.472+0900 E/W_HOME  ( 2241): main.c: _window_focus_out_cb(885) > win[25165827], ev->win[25165831]
03-23 18:46:22.472+0900 D/APPS    ( 2241): apps_main.c: _window_focus_out_cb(308) >  focus out
03-23 18:46:22.472+0900 E/W_HOME  ( 2241): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-23 18:46:22.472+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(656) >  Pause starts
03-23 18:46:22.472+0900 D/APPS    ( 2241): apps_main.c: apps_main_pause(676) >  Pause done
03-23 18:46:22.542+0900 D/APP_CORE( 4985): appcore.c: __prt_ltime(183) > [APP 4985] first idle after reset: 191 msec
03-23 18:46:22.542+0900 D/APP_CORE( 4985): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
03-23 18:46:22.542+0900 D/APP_CORE( 4985): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800007 fully_obscured 1
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(470) > [APP 2241] Event: PAUSE State: RUNNING
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __do_app(538) > [APP 2241] PAUSE
03-23 18:46:22.552+0900 I/CAPI_APPFW_APPLICATION( 2241): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-23 18:46:22.552+0900 D/W_HOME  ( 2241): main.c: _pause_cb(600) > Paused
03-23 18:46:22.552+0900 E/W_HOME  ( 2241): main.c: _pause_cb(603) > paused already
03-23 18:46:22.552+0900 D/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:22.552+0900 E/APP_CORE( 2241): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:22.552+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2241, type = 2
03-23 18:46:22.572+0900 D/AUL_AMD ( 2167): amd_launch.c: __e17_status_handler(1911) > pid(4985) status(3)
03-23 18:46:22.572+0900 D/RESOURCED( 2337): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4985, type = 0
03-23 18:46:22.572+0900 D/RESOURCED( 2337): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4985
03-23 18:46:22.572+0900 I/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4985, oom : 200
03-23 18:46:22.572+0900 E/RESOURCED( 2337): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-23 18:46:22.622+0900 D/APP_CORE( 4985): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
03-23 18:46:22.622+0900 D/APP_CORE( 4985): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-23 18:46:22.622+0900 D/APP_CORE( 4985): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-23 18:46:22.632+0900 D/APP_CORE( 4985): appcore-efl.c: __do_app(470) > [APP 4985] Event: RESUME State: RUNNING
03-23 18:46:22.632+0900 D/LAUNCH  ( 4985): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
03-23 18:46:22.632+0900 D/LAUNCH  ( 4985): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
03-23 18:46:22.632+0900 D/LAUNCH  ( 4985): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
03-23 18:46:22.632+0900 D/APP_CORE( 4985): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-23 18:46:22.632+0900 E/APP_CORE( 4985): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-23 18:46:23.382+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(113) > pid(4960)
03-23 18:46:23.382+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-23 18:46:23.402+0900 W/CRASH_MANAGER( 4751): worker.c: worker_job(1189) > 1104985626173145872638
