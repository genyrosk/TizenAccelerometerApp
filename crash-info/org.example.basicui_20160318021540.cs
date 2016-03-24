S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:39

Crash Information
Process Name: basicui
PID: 3055
Date: 2016-03-18 02:15:40+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb45818f8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbfe458f8
ebp = 0xbfe45948, esp = 0xbfe458a8
eax = 0x30302e30, ebx = 0xb4582d20
ecx = 0xbfe458f8, edx = 0xf473c000
eip = 0xb74d57ad

Memory Information
MemTotal:      124 KB
MemFree:        54 KB
Buffers:         4 KB
Cached:     138632 KB
VmPeak:      70196 KB
VmSize:      70196 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12584 KB
VmRSS:       12584 KB
VmData:      11428 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31784 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3055 TID = 3055
3055 3059 

Maps Information
b35df000 b3603000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b376c000 b376f000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3770000 b377e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b377f000 b378e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3f94000 b3f97000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f98000 b3f9b000 r-xp /usr/lib/libdri2.so.0.0.0
b3f9c000 b3fa7000 r-xp /usr/lib/libdrm.so.2.4.0
b3fa8000 b3fb1000 r-xp /usr/lib/libtbm.so.1.0.0
b3fb2000 b3fb9000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3fba000 b3fc3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3fc4000 b3fcb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fcc000 b3fd2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3fd3000 b3fdb000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fdc000 b3fe0000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3fe1000 b3ffe000 r-xp /usr/lib/libtts.so
b3fff000 b4143000 r-xp /usr/lib/libcairo.so.2.11200.14
b4147000 b415f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4160000 b4181000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4182000 b4192000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4193000 b419e000 r-xp /lib/libnss_files-2.13.so
b43a0000 b43c7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43c8000 b43ed000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b43ee000 b450f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b451f000 b4555000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4557000 b455a000 r-xp /usr/lib/libiniparser.so.0
b455c000 b4566000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4567000 b4570000 r-xp /usr/lib/libappsvc.so.0.1.0
b4571000 b4574000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4576000 b4578000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4579000 b457f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b4580000 b4582000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b4583000 b4589000 r-xp /usr/lib/libogg.so.0.7.1
b458a000 b45b5000 r-xp /usr/lib/libvorbis.so.0.4.3
b45b6000 b46a1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46af000 b46b1000 r-xp /usr/lib/libXau.so.6.0.0
b46b2000 b4712000 r-xp /usr/lib/libssl.so.1.0.0
b4717000 b4748000 r-xp /usr/lib/libidn.so.11.5.44
b4749000 b4759000 r-xp /usr/lib/libcares.so.2.1.0
b475a000 b47c3000 r-xp /usr/lib/libsndfile.so.1.0.25
b47c9000 b47d3000 r-xp /usr/lib/libsensord-share.so
b47d4000 b47fa000 r-xp /lib/libexpat.so.1.5.2
b47fc000 b4823000 r-xp /usr/lib/libpng12.so.0.50.0
b4824000 b4844000 r-xp /usr/lib/libxcb.so.1.1.0
b4845000 b48b4000 r-xp /usr/lib/libcurl.so.4.3.0
b48b6000 b48c1000 r-xp /usr/lib/libethumb.so.1.7.99
b5e21000 b5ef9000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f05000 b5f08000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f09000 b5f1f000 r-xp /usr/lib/libremix.so.0.0.0
b5f20000 b5f22000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f23000 b5f4f000 r-xp /usr/lib/liblua-5.1.so
b5f50000 b5f5a000 r-xp /usr/lib/libembryo.so.1.7.99
b5f5b000 b5fa1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fb2000 b5fd0000 r-xp /usr/lib/libsensor.so.1.1.0
b5fd2000 b6054000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6059000 b608d000 r-xp /usr/lib/libfontconfig.so.1.5.0
b608f000 b60ea000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60ec000 b6102000 r-xp /usr/lib/libfribidi.so.0.3.1
b6103000 b618f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6193000 b6196000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6197000 b619d000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b619e000 b61a4000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61a6000 b61b7000 r-xp /usr/lib/libXext.so.6.4.0
b61b8000 b62ec000 r-xp /usr/lib/libX11.so.6.3.0
b62f0000 b62f5000 r-xp /usr/lib/libXtst.so.6.1.0
b62f6000 b62fe000 r-xp /usr/lib/libXrender.so.1.3.0
b62ff000 b6308000 r-xp /usr/lib/libXrandr.so.2.2.0
b6309000 b630b000 r-xp /usr/lib/libXinerama.so.1.0.0
b630c000 b631a000 r-xp /usr/lib/libXi.so.6.1.0
b631b000 b631f000 r-xp /usr/lib/libXfixes.so.3.1.0
b6320000 b6322000 r-xp /usr/lib/libXgesture.so.7.0.0
b6323000 b6325000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6326000 b6328000 r-xp /usr/lib/libXdamage.so.1.1.0
b6329000 b6332000 r-xp /usr/lib/libXcursor.so.1.0.2
b6333000 b635e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6360000 b6368000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6369000 b6374000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6375000 b637b000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b637c000 b639d000 r-xp /usr/lib/libefreet.so.1.7.99
b639f000 b63ab000 r-xp /usr/lib/libedbus.so.1.7.99
b63ac000 b650b000 r-xp /usr/lib/libicuuc.so.51.1
b6519000 b6722000 r-xp /usr/lib/libicui18n.so.51.1
b672b000 b67c8000 r-xp /usr/lib/libedje.so.1.7.99
b67ca000 b67db000 r-xp /usr/lib/libecore_input.so.1.7.99
b67dc000 b67e3000 r-xp /usr/lib/libecore_file.so.1.7.99
b67e4000 b680a000 r-xp /usr/lib/libeet.so.1.7.99
b6813000 b693b000 r-xp /usr/lib/libevas.so.1.7.99
b6958000 b698b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b698d000 b69d1000 r-xp /usr/lib/libecore_x.so.1.7.99
b69d3000 b6bcd000 r-xp /usr/lib/libelementary.so.1.7.99
b6bde000 b6be4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6be5000 b6be9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bed000 b6bee000 r-xp /usr/lib/libjournal.so.0.1.0
b6bef000 b6d37000 r-xp /usr/lib/libxml2.so.2.7.8
b6d3e000 b6d51000 r-xp /lib/libresolv-2.13.so
b6d55000 b6d72000 r-xp /lib/libz.so.1.2.5
b6d73000 b6d76000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d77000 b6d7c000 r-xp /usr/lib/libffi.so.5.0.10
b6d7d000 b6d7e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d80000 b6d84000 r-xp /lib/libattr.so.1.1.0
b6d85000 b6f97000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fb2000 b6fd3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fd4000 b6ffc000 r-xp /lib/libm-2.13.so
b6ffe000 b7059000 r-xp /usr/lib/libeina.so.1.7.99
b705c000 b7067000 r-xp /usr/lib/libvconf.so.0.2.45
b7068000 b706b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b706c000 b70ba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70bb000 b721c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7220000 b7227000 r-xp /lib/librt-2.13.so
b722a000 b7231000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7233000 b724d000 r-xp /lib/libgcc_s-4.6.4.so.1
b724e000 b7256000 r-xp /lib/libcrypt-2.13.so
b727f000 b7283000 r-xp /lib/libcap.so.2.21
b7284000 b7286000 r-xp /usr/lib/libiri.so
b7288000 b72b4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72b5000 b72d5000 r-xp /usr/lib/libecore.so.1.7.99
b72e4000 b72ed000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72ee000 b7411000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7412000 b7425000 r-xp /usr/lib/libail.so.0.1.0
b7427000 b744c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b744d000 b7457000 r-xp /lib/libunwind.so.8.0.1
b7461000 b75d2000 r-xp /lib/libc-2.13.so
b75d8000 b7622000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7623000 b7628000 r-xp /usr/lib/libbundle.so.0.1.22
b7629000 b762c000 r-xp /lib/libdl-2.13.so
b762f000 b7634000 r-xp /usr/lib/libsmack.so.1.0.0
b7635000 b76dd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76e0000 b76fa000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76fb000 b7712000 r-xp /lib/libpthread-2.13.so
b7716000 b7719000 r-xp /usr/lib/libdlog.so.0.0.0
b771a000 b772a000 r-xp /usr/lib/libaul.so.0.1.0
b772c000 b7732000 r-xp /usr/lib/libappcore-common.so.1.1
b7733000 b7738000 r-xp /usr/lib/libappcore-efl.so.1.1
b773a000 b773f000 r-xp /usr/lib/libsys-assert.so
b7742000 b7760000 r-xp /lib/ld-2.13.so
b7760000 b7761000 r-xp [vdso]
b7763000 b776a000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:3055)
Call Stack Count: 8
 0: strcat + 0x12d (0xb74d57ad) [/lib/libc.so.6] + 0x747ad
 1: app_create + 0x2f (0xb458119f) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x119f
 2: (0xb6be63cf) [/usr/lib/libcapi-appfw-application.so.0] + 0x13cf
 3: appcore_efl_main + 0x293 (0xb7735d53) [/usr/lib/libappcore-efl.so.1] + 0x2d53
 4: ui_app_main + 0x130 (0xb6be75f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
 5: main + 0x2b0 (0xb4581110) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1110
 6: (0xb77665b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77665b1
 7: __libc_start_main + 0xf3 (0xb747a0f3) [/lib/libc.so.6] + 0x190f3
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
3
03-18 02:15:31.758+0900 D/APP_CORE( 3011): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:2000003
03-18 02:15:31.758+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:1247] focusedCallback(): entered
03-18 02:15:31.758+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:576] getCurrentWebview(): get current webview
03-18 02:15:31.788+0900 D/APP_CORE( 2255): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00007 fully_obscured 1
03-18 02:15:31.788+0900 D/APP_CORE( 2255): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
03-18 02:15:31.788+0900 D/APP_CORE( 2255): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
03-18 02:15:31.788+0900 D/APP_CORE( 2255): appcore-efl.c: __do_app(470) > [APP 2255] Event: PAUSE State: PAUSED
03-18 02:15:31.788+0900 D/APP_CORE( 2255): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-18 02:15:31.788+0900 E/APP_CORE( 2255): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-18 02:15:31.788+0900 D/RESOURCED( 2340): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2255, type = 2
03-18 02:15:31.788+0900 D/RESOURCED( 2340): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 3011, type = 0
03-18 02:15:31.788+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 3011
03-18 02:15:31.788+0900 I/RESOURCED( 2340): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 3011, oom : 200
03-18 02:15:31.788+0900 E/RESOURCED( 2340): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-18 02:15:31.788+0900 D/RESOURCED( 2340): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 3011, appname = (null)
03-18 02:15:31.788+0900 D/RESOURCED( 2340): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3011
03-18 02:15:31.788+0900 D/AUL_AMD ( 2144): amd_launch.c: __e17_status_handler(1911) > pid(3011) status(3)
03-18 02:15:31.808+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:31.808+0900 D/APP_CORE( 3011): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:2000003 fully_obscured 0
03-18 02:15:31.808+0900 D/APP_CORE( 3011): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-18 02:15:31.808+0900 D/APP_CORE( 3011): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-18 02:15:31.808+0900 D/APP_CORE( 3011): appcore-efl.c: __do_app(470) > [APP 3011] Event: RESUME State: RUNNING
03-18 02:15:31.808+0900 D/LAUNCH  ( 3011): appcore-efl.c: __do_app(557) > [Basic:Application:resume:start]
03-18 02:15:31.808+0900 D/LAUNCH  ( 3011): appcore-efl.c: __do_app(567) > [Basic:Application:resume:done]
03-18 02:15:31.808+0900 D/LAUNCH  ( 3011): appcore-efl.c: __do_app(569) > [Basic:Application:Launching:done]
03-18 02:15:31.808+0900 D/APP_CORE( 3011): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-18 02:15:31.808+0900 E/APP_CORE( 3011): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-18 02:15:31.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:31.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:31.878+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(113) > pid(2986)
03-18 02:15:31.878+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-18 02:15:31.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:31.958+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history NxjvjzJaRh.Basic /opt/usr/apps/NxjvjzJaRh/bin/NxjvjzJaRh.Basic
03-18 02:15:31.958+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 02:15:31.958+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 02:15:31.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:32.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:33.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:34.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:35.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:36.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.428+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.478+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.528+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.578+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.628+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.678+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.728+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.778+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.828+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.878+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.928+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:37.978+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.028+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.078+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.128+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.178+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.228+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.278+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.328+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.328+0900 D/IMMODULE( 3011): isf_imf_context.cpp: initialize(3304) > Initializing Ecore ISF IMModule...
03-18 02:15:38.328+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-socket-frontend, NxjvjzJaRh.Basi
03-18 02:15:38.328+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.328+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-socket-frontend, NxjvjzJaRh.Basi
03-18 02:15:38.328+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-socket-frontend, NxjvjzJaRh.Basi
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-socket-frontend, NxjvjzJaRh.Basi
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-panel-socket:0, NxjvjzJaRh.Basi
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  ppid:2200  trying connect() to local:/tmp/scim-panel-socket:0, NxjvjzJaRh.Basi
03-18 02:15:38.358+0900 D/ISF_UTILITY( 3011): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:3011  scim_socket.cpp  connect  connect() succeeded
03-18 02:15:38.358+0900 D/IMMODULE( 3011): isf_imf_control_ui.cpp: isf_imf_input_panel_init(505) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
03-18 02:15:38.378+0900 D/IMMODULE( 3011): isf_imf_context.cpp: isf_imf_context_add(1172) > create_instance: c6bebc27-6324-4b77-8ad4-6d41dcaf2e08
03-18 02:15:38.378+0900 D/IMMODULE( 3011): isf_imf_context.cpp: isf_imf_context_input_hint_set(2192) > ctx : 0xb993d0e8, input hint : 0x1
03-18 02:15:38.378+0900 D/ConsoleMessage( 3011): file:///opt/usr/apps/NxjvjzJaRh/res/wgt/js/main.js:30:-9.800403594970703
03-18 02:15:38.378+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:2172] eaKeyCallback(): Key = [0]
03-18 02:15:38.378+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [dispatch_event_support.cpp:167] dispatchHwKeyEvent(): dispatchHwKeyEvent(0xb97b78d0, back)
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationManager.cpp: getClassRef(123) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationControl.cpp: getClassRef(83) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationControlData.cpp: getClassRef(73) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): plugin_initializer.cpp: on_widget_start_callback(73) > [Tizen1_0\Application] on_widget_start_callback (5)
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): plugin_initializer.cpp: on_frame_load_callback(101) > [Tizen\application] on_frame_load_callback (0xb158fc8c)
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationManager.cpp: initialize(139) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationFactory.cpp: getInstance(33) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationFactory.cpp: ApplicationFactory(40) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationFactory.cpp: createApplication(27) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: ApplicationManager(578) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationController.cpp: ApplicationController(52) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS( 3013): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [JSObjectDeclaration.cpp:106] invokeCallback(): JS Object create, notice.
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationManager.cpp: getCurrentApplication(171) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: getCurrentApplication(851) > Entered
03-18 02:15:38.378+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: get_current_app_id(300) > Entered
03-18 02:15:38.398+0900 D/AUL     ( 3013): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 3011, pid = 3013
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: create_app_info(330) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: ApplicationInformation(36) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setAppId(72) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setName(60) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setIconPath(84) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setShow(108) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: category_cb(319) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: addCategories(126) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setPackageId(162) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setVersion(96) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationInformation.cpp: setInstallDate(138) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): Application.cpp: Application(39) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): Application.cpp: setAppInfo(67) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): ApplicationManager.cpp: getCurrentApplication(877) > set appinfo to application
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): Application.cpp: setContextId(55) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplication.cpp: makeObject(108) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplication.cpp: getClassRef(83) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplication.cpp: initialize(92) > Entered
03-18 02:15:38.398+0900 D/WRT_UNDEFINED( 3013): ApplicationConverter.cpp: ApplicationConverter(50) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): Application.cpp: getAppInfo(61) > Entered
03-18 02:15:38.398+0900 D/WRT_UNDEFINED( 3013): ApplicationConverter.cpp: toJSValueRefFromApplicationInformation(122) > Entered
03-18 02:15:38.398+0900 D/WRT_UNDEFINED( 3013): JSApplicationInformation.h: JSApplicationInformationPriv(55) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationInformation.cpp: getClassRef(73) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplicationInformation.cpp: initialize(118) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): Application.cpp: getContextId(49) > Entered
03-18 02:15:38.398+0900 D/WRT_UNDEFINED( 3013): ApplicationConverter.cpp: ~ApplicationConverter(55) > Entered
03-18 02:15:38.398+0900 D/WRT_PLUGINS/TIZEN( 3013): JSApplication.cpp: exit(137) > Entered
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [ewk_context_manager.cpp:309] messageFromInjectedBundleCallback(): enter
03-18 02:15:38.398+0900 D/AUL     ( 3011): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-18 02:15:38.398+0900 D/APP_CORE( 3011): appcore-efl.c: __after_loop(1062) > [APP 3011] PAUSE before termination
03-18 02:15:38.398+0900 I/CAPI_APPFW_APPLICATION( 3011): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [runnable_widget_object.cpp:145] Suspend(): Suspending widget
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:341] suspendWidget(): Pausing widget
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:1039] setEwkViewInvisible(): setEwkViewInvisible called
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:1073] suspendWebkit(): suspendWebkit : 0xb97b78d0
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:1079] suspendWebkit(): background support is disabled. suspend view
03-18 02:15:38.398+0900 D/WEBKIT  ( 3011): void ewk_view_suspend(Evas_Object*)(1132) > 
03-18 02:15:38.398+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [runnable_widget_object.cpp:248] setNewState(): RunnableWidgetObject changes state to: SUSPENDED
03-18 02:15:38.398+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 22
03-18 02:15:38.408+0900 D/WEBKIT  ( 3013): virtual void WebKit::DrawingAreaImpl::suspendPainting()(486) > 0
03-18 02:15:38.408+0900 D/WEBKIT  ( 3013): virtual void WebKit::DrawingAreaImpl::suspendPainting()(486) > 1
03-18 02:15:38.408+0900 D/WEBKIT  ( 3013): virtual void WebKit::DrawingAreaImpl::suspendPainting()(486) > 1
03-18 02:15:38.408+0900 I/CAPI_APPFW_APPLICATION( 3011): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:279] OnTerminate(): Wrt Shutdown now
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:1171] shutdownStep(): Closing Wrt connection ...
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:960] unsetTimeout(): enter
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:960] unsetTimeout(): enter
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:960] unsetTimeout(): enter
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:325] hideWidget(): hiding widget
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic_storage_support.cpp:99] deinitializeStorage(): deinitializeStorage
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic_storage_support.cpp:45] removeFile(): /opt/usr/apps/NxjvjzJaRh/tmp
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic_storage_support.cpp:49] removeFile(): Skip root directory
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic_apps_support.cpp:302] deinitialize(): Deinitialized
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic_vibration_support.cpp:42] deinitialize(): deinitialize
03-18 02:15:38.408+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3011): system_settings.c: system_settings_unset_changed_cb(648) > Enter [system_settings_unset_changed_cb]
03-18 02:15:38.408+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3011): system_settings.c: system_settings_get_item(443) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
03-18 02:15:38.408+0900 D/SYSTEM-SETTINGS( 3011): system_setting_platform.c: system_setting_unset_changed_callback_font_type(1042) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_font_type. [0m
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:333] hideWidget(): pop webview: 0xb97b78d0
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:1024] removeEwkView(): removeEwkView called
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [view_logic.cpp:817] ewkClientDeinit(): ewkClientDeinit
03-18 02:15:38.408+0900 D/IMMODULE( 3011): isf_imf_control_ui.cpp: isf_imf_context_input_panel_hide(677) > [SECURE_LOG] ctx : 0xb993d0e8
03-18 02:15:38.408+0900 E/efl-extension( 3011): efl_extension_rotary.c: _activated_obj_del_cb(618) > _activated_obj_del_cb : 0xb97b78d0
03-18 02:15:38.408+0900 E/efl-extension( 3011): efl_extension_rotary.c: _object_deleted_cb(583) > In: data: 0xb97b78d0, obj: 0xb97b78d0
03-18 02:15:38.408+0900 I/efl-extension( 3011): efl_extension_rotary.c: _remove_ecore_handlers(565) > In
03-18 02:15:38.408+0900 I/efl-extension( 3011): efl_extension_rotary.c: _remove_ecore_handlers(570) > removed _motion_handler
03-18 02:15:38.408+0900 I/efl-extension( 3011): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _rotate_handler
03-18 02:15:38.408+0900 I/efl-extension( 3011): efl_extension_rotary.c: _object_deleted_cb(612) > done
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [runnable_widget_object.cpp:248] setNewState(): RunnableWidgetObject changes state to: HIDEN
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [runnable_widget_object.cpp:254] ~RunnableWidgetObject(): 
03-18 02:15:38.408+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [window_data.cpp:63] ~WindowData(): 
03-18 02:15:38.418+0900 D/RESOURCED( 2340): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2255, type = 0
03-18 02:15:38.418+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2255
03-18 02:15:38.418+0900 E/RESOURCED( 2340): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2255) didn't have any process list
03-18 02:15:38.418+0900 D/RESOURCED( 2340): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2255, appname = (null)
03-18 02:15:38.418+0900 D/RESOURCED( 2340): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2255
03-18 02:15:38.418+0900 D/AUL_AMD ( 2144): amd_launch.c: __e17_status_handler(1911) > pid(2255) status(3)
03-18 02:15:38.438+0900 D/IMMODULE( 3011): isf_imf_context.cpp: isf_imf_context_shutdown(1132) > immodule shutdown
03-18 02:15:38.438+0900 D/IMMODULE( 3011): isf_imf_control_ui.cpp: _send_input_panel_hide_request(328) > [SECURE_LOG] Send input panel hide request
03-18 02:15:38.438+0900 D/IMMODULE( 3011): isf_imf_control_ui.cpp: isf_imf_input_panel_shutdown(521) > [SECURE_LOG] candidate_conformant_reset_done = 1
03-18 02:15:38.438+0900 D/IMMODULE( 3011): isf_imf_context.cpp: finalize(3432) > Finalizing Ecore ISF IMModule...
03-18 02:15:38.438+0900 D/ISF_UTILITY( 2241): scim_utility.cpp: isf_save_log(1436) > time:1458234938  pid:2241  scim_panel_agent.cpp  hide_ise_panel  prepare to hide ISE, 30 -1
03-18 02:15:38.458+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:1700] main(): App returned: 0
03-18 02:15:38.458+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:1702] main(): WrtClient returned: 0
03-18 02:15:38.458+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [wrt-client.cpp:148] ~WrtClient(): App Finished
03-18 02:15:38.468+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [thread_database_support.h:197] DetachFromThread(): Detaching thread database connection: /opt/dbspace/.ace.db
03-18 02:15:38.468+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [thread_database_support.h:100] CheckedConnectionDelete(): Destroying thread database connection: /opt/dbspace/.ace.db
03-18 02:15:38.468+0900 D/WRT     ( 3011): dlog_log_provider.cpp: Debug(74) > [SECURE_LOG] [core_module.cpp:90] ~CoreModuleImpl(): Core module implementation destroyed
03-18 02:15:38.468+0900 I/efl-extension( 3011): efl_extension.c: eext_mod_shutdown(45) > Shutdown
03-18 02:15:38.468+0900 D/WRT_LAUNCHPAD( 2200): sigchild.h: __launchpad_sig_child(149) > dead_pid = 3011 pgid = 3011
03-18 02:15:38.468+0900 D/WRT_LAUNCHPAD( 2200): sigchild.h: __send_app_dead_signal(80) > send dead signal done
03-18 02:15:38.468+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 3011)
03-18 02:15:38.468+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3011
03-18 02:15:38.468+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 02:15:38.468+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 02:15:38.468+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 02:15:38.548+0900 E/W_HOME  ( 2255): main.c: _window_focus_in_cb(851) > win[14680067], ev->win[14680071]
03-18 02:15:38.548+0900 D/APPS    ( 2255): apps_main.c: _window_focus_in_cb(288) >  focus in
03-18 02:15:38.548+0900 E/W_HOME  ( 2255): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-18 02:15:38.548+0900 D/APPS    ( 2255): apps_main.c: apps_main_resume(693) >  Resume starts
03-18 02:15:38.548+0900 D/APPS    ( 2255): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-18 02:15:38.548+0900 E/efl-extension( 2255): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb84fd120, elm_scroller, _activated_obj : 0xb84fd120, activated : 1
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:e00007 fully_obscured 0
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __do_app(470) > [APP 2255] Event: RESUME State: PAUSED
03-18 02:15:38.548+0900 D/LAUNCH  ( 2255): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __do_app(559) > [APP 2255] RESUME
03-18 02:15:38.548+0900 I/CAPI_APPFW_APPLICATION( 2255): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
03-18 02:15:38.548+0900 D/W_HOME  ( 2255): main.c: _resume_cb(564) > Resumed
03-18 02:15:38.548+0900 D/APPS    ( 2255): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
03-18 02:15:38.548+0900 E/W_HOME  ( 2255): main.c: _resume_cb(576) > Apps is showing
03-18 02:15:38.548+0900 D/LAUNCH  ( 2255): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
03-18 02:15:38.548+0900 D/LAUNCH  ( 2255): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
03-18 02:15:38.548+0900 D/APP_CORE( 2255): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-18 02:15:38.548+0900 E/APP_CORE( 2255): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-18 02:15:38.548+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(3011) is dead
03-18 02:15:38.548+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 02:15:39.628+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 02:15:39.678+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5959635 button=1
03-18 02:15:39.678+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [189,240]
03-18 02:15:39.788+0900 D/APPS    ( 2255): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-18 02:15:40.048+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5960053 button=1
03-18 02:15:40.048+0900 D/APPS    ( 2255): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-18 02:15:40.048+0900 D/APPS    ( 2255): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-18 02:15:40.048+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [189,98]
03-18 02:15:40.258+0900 D/APPS    ( 2255): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
03-18 02:15:40.408+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(113) > pid(3011)
03-18 02:15:40.408+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-18 02:15:40.738+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 02:15:40.798+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5960749 button=1
03-18 02:15:40.798+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [101,231]
03-18 02:15:40.798+0900 D/APPS    ( 2255): item.c: _down_cb(381) >  Down (basicui,0xb8627fb8) (101, 231), item pos(6,202,166,144)
03-18 02:15:40.798+0900 E/APPS    ( 2255): item.c: _down_cb(425) >  longpress edit mode disable
03-18 02:15:40.818+0900 W/APPS    ( 2255): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-18 02:15:40.858+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5960869 button=1
03-18 02:15:40.858+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [101,231]
03-18 02:15:40.858+0900 D/APPS    ( 2255): item.c: _up_cb(573) >  Up (basicui,0xb8627fb8) (101, 231), item pos(6,202,166,144)
03-18 02:15:40.858+0900 E/APPS    ( 2255): item.c: _clicked_cb(65) >  Clicked
03-18 02:15:40.858+0900 E/APPS    ( 2255): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-18 02:15:40.858+0900 D/APPS    ( 2255): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-18 02:15:40.858+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 02:15:40.858+0900 D/APP_SVC ( 2255): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-18 02:15:40.858+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 02:15:40.858+0900 D/W_HOME  ( 2255): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-18 02:15:40.858+0900 D/W_HOME  ( 2255): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-18 02:15:40.858+0900 D/APP_SVC ( 2255): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-18 02:15:40.858+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-18 02:15:40.858+0900 D/AUL     ( 2255): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-18 02:15:40.868+0900 E/AUL_AMD ( 2144): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 02:15:40.868+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 02:15:40.868+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 02:15:40.868+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 02:15:40.868+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 02:15:40.868+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 3055 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 02:15:40.868+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-18 02:15:40.878+0900 D/AUL_PAD ( 3055): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-18 02:15:40.878+0900 D/LAUNCH  ( 3055): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 02:15:40.888+0900 I/efl-extension( 3055): efl_extension.c: eext_mod_init(39) > Init
03-18 02:15:40.888+0900 I/CAPI_APPFW_APPLICATION( 3055): app_main.c: ui_app_main(701) > app_efl_main
03-18 02:15:40.888+0900 D/LAUNCH  ( 3055): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 02:15:40.908+0900 D/APP_CORE( 3055): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 02:15:40.908+0900 D/AUL     ( 3055): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 3055 is org.example.basicui
03-18 02:15:40.908+0900 D/APP_CORE( 3055): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 02:15:40.908+0900 D/APP_CORE( 3055): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 02:15:40.908+0900 D/AUL     ( 3055): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 02:15:40.908+0900 D/LAUNCH  ( 3055): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 02:15:40.908+0900 I/CAPI_APPFW_APPLICATION( 3055): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 02:15:40.928+0900 E/EFL     ( 3055): eina_module<3055> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 02:15:40.938+0900 E/EFL     ( 3055): ecore_evas<3055> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 02:15:40.958+0900 W/CRASH_MANAGER( 2944): worker.c: worker_job(1189) > 1103055626173145823494
