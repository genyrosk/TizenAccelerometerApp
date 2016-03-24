S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:39

Crash Information
Process Name: basicui
PID: 2708
Date: 2016-03-18 02:10:57+0900
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
MemFree:        56 KB
Buffers:         4 KB
Cached:     133732 KB
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
PID = 2708 TID = 2708
2708 2712 

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

Callstack Information (PID:2708)
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
ignal. Exit function
03-18 02:10:43.321+0900 D/rpm-installer( 2595): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-18 02:10:43.321+0900 D/rpm-installer( 2595): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-18 02:10:43.321+0900 D/rpm-installer( 2595): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-18 02:10:43.331+0900 D/PKGMGR_SERVER( 2594): pkgmgr-server.c: sighandler(326) > child exit [2595]
03-18 02:10:43.331+0900 D/PKGMGR_SERVER( 2594): pkgmgr-server.c: sighandler(341) > child NORMAL exit [2595]
03-18 02:10:43.341+0900 D/APPS    ( 2255): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-18 02:10:43.341+0900 D/APPS    ( 2255): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [49]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 02:10:43.341+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 02:10:43.341+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 47 (recv_fd: -1)
03-18 02:10:43.341+0900 D/APPS    ( 2255): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [52]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-18 02:10:43.341+0900 D/BADGE   ( 2273): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 02:10:43.341+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-18 02:10:43.341+0900 E/DATA_PROVIDER_MASTER( 2273): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2273, fd: -1
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2273), fd: -1
03-18 02:10:43.341+0900 D/COM_CORE( 2255): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 47 (recv_fd: -1)
03-18 02:10:43.351+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-18 02:10:43.351+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 02:10:43.351+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8a18b30 is terminated (NIL packet)
03-18 02:10:43.351+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 02:10:43.351+0900 D/COM_CORE( 2273): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-18 02:10:43.351+0900 D/DATA_PROVIDER_MASTER( 2273): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8a13a18 is terminated (NIL packet)
03-18 02:10:43.351+0900 D/DATA_PROVIDER_MASTER( 2273): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-18 02:10:43.351+0900 D/APPS    ( 2255): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-18 02:10:43.351+0900 D/APPS    ( 2255): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-18 02:10:43.351+0900 D/BADGE   ( 2255): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-18 02:10:43.351+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-18 02:10:43.351+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [S80gBD4gGw.Basic]'s ordering : 1
03-18 02:10:43.351+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.accel]'s ordering : 2
03-18 02:10:43.351+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [NxjvjzJaRh.Basic]'s ordering : 3
03-18 02:10:43.351+0900 D/APPS    ( 2255): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 4
03-18 02:10:43.351+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-18 02:10:43.361+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[S80gBD4gGw.Basic:1]
03-18 02:10:43.361+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[org.example.accel:2]
03-18 02:10:43.361+0900 D/APPS    ( 2255): db.c: apps_db_update_item(374) >  Update the item[NxjvjzJaRh.Basic:3]
03-18 02:10:43.371+0900 D/APPS    ( 2255): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:4]
03-18 02:10:43.371+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-18 02:10:43.371+0900 D/PKGMGR  ( 2255): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-18 02:10:44.991+0900 D/PKGMGR_SERVER( 2594): pkgmgr-server.c: exit_server(724) > exit_server Start
03-18 02:10:44.991+0900 D/PKGMGR_SERVER( 2594): pkgmgr-server.c: main(1516) > Quit main loop.
03-18 02:10:44.991+0900 D/PKGMGR_SERVER( 2594): pkgmgr-server.c: main(1524) > package manager server terminated.
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 02:10:46.571+0900 D/AUL     ( 2144): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2649, pid = 2651
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 02:10:46.571+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 02:10:46.571+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 02:10:46.571+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 02:10:46.571+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 02:10:46.571+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2652 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 02:10:46.571+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 02:10:46.571+0900 D/AUL_PAD ( 2652): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 02:10:46.571+0900 D/AUL_PAD ( 2652): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 02:10:46.571+0900 D/AUL_PAD ( 2652): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 02:10:46.581+0900 D/AUL_PAD ( 2652): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 02:10:46.581+0900 D/AUL_PAD ( 2652): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 02:10:46.581+0900 D/AUL_PAD ( 2652): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-18 02:10:46.581+0900 D/AUL_PAD ( 2652): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-18 02:10:46.581+0900 D/LAUNCH  ( 2652): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 02:10:46.581+0900 I/efl-extension( 2652): efl_extension.c: eext_mod_init(39) > Init
03-18 02:10:46.581+0900 I/CAPI_APPFW_APPLICATION( 2652): app_main.c: ui_app_main(701) > app_efl_main
03-18 02:10:46.581+0900 D/LAUNCH  ( 2652): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 02:10:46.601+0900 D/APP_CORE( 2652): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 02:10:46.601+0900 D/AUL     ( 2652): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2652 is org.example.basicui
03-18 02:10:46.601+0900 D/APP_CORE( 2652): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 02:10:46.601+0900 D/APP_CORE( 2652): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 02:10:46.601+0900 D/AUL     ( 2652): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 02:10:46.601+0900 D/LAUNCH  ( 2652): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 02:10:46.601+0900 I/CAPI_APPFW_APPLICATION( 2652): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 02:10:46.621+0900 E/EFL     ( 2652): eina_module<2652> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 02:10:46.631+0900 E/EFL     ( 2652): ecore_evas<2652> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 02:10:46.661+0900 W/CRASH_MANAGER( 2657): worker.c: worker_job(1189) > 11026526261731458234646
03-18 02:10:46.691+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 02:10:46.691+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 02:10:46.691+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 02:10:46.691+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 02:10:46.691+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 2652, type 4 
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 2652
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
03-18 02:10:46.691+0900 E/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 357
03-18 02:10:46.691+0900 D/RESOURCED( 2340): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 02:10:46.701+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2652 pgid = 2652
03-18 02:10:46.701+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(2652)
03-18 02:10:46.701+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 02:10:46.701+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 02:10:46.701+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 02:10:46.701+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2652
03-18 02:10:46.701+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 02:10:46.701+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 02:10:46.701+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 02:10:46.701+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(2652) is dead
03-18 02:10:46.701+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 02:10:46.701+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2652)
03-18 02:10:47.681+0900 D/AUL_AMD ( 2144): amd_launch.c: __grab_timeout_handler(1212) > pid(2652) ecore_x_pointer_ungrab
03-18 02:10:47.681+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-18 02:10:47.681+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 02:10:47.681+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.261+0900 D/PKGMGR_INFO( 2657): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.391+0900 D/AUL     ( 2678): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
03-18 02:10:48.391+0900 D/AUL     ( 2678): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
03-18 02:10:48.391+0900 D/AUL     ( 2144): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2085, pid = 2678
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
03-18 02:10:48.391+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 02:10:48.391+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 02:10:48.391+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
03-18 02:10:48.391+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 02:10:48.391+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2679 /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-18 02:10:48.391+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 02:10:48.391+0900 D/AUL_PAD ( 2679): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 02:10:48.391+0900 D/AUL_PAD ( 2679): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 02:10:48.391+0900 D/AUL_PAD ( 2679): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
03-18 02:10:48.401+0900 D/AUL_PAD ( 2679): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
03-18 02:10:48.401+0900 D/LAUNCH  ( 2679): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
03-18 02:10:48.421+0900 D/LAUNCH  ( 2679): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
03-18 02:10:48.431+0900 D/APP_CORE( 2679): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 02:10:48.431+0900 D/AUL     ( 2679): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2679 is org.tizen.crash-popup
03-18 02:10:48.431+0900 D/APP_CORE( 2679): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
03-18 02:10:48.431+0900 D/APP_CORE( 2679): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 02:10:48.431+0900 D/AUL     ( 2679): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 02:10:48.431+0900 D/LAUNCH  ( 2679): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
03-18 02:10:48.441+0900 D/EFL-ASSIST( 2679): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
03-18 02:10:48.441+0900 D/EFL-ASSIST( 2679): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b829ebb8]
03-18 02:10:48.441+0900 D/EFL-ASSIST( 2679): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b82bf958) from (/usr/share/themes/ChangeableColorTable1.xml) is created
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b82bf958) is freed
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
03-18 02:10:48.441+0900 I/EFL-ASSIST( 2679): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
03-18 02:10:48.441+0900 D/APP_CORE( 2679): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 02:10:48.441+0900 D/LAUNCH  ( 2679): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
03-18 02:10:48.441+0900 D/APP_CORE( 2679): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
03-18 02:10:48.441+0900 D/APP_CORE( 2679): appcore.c: __aul_handler(423) > [APP 2679]     AUL event: AUL_START
03-18 02:10:48.441+0900 D/APP_CORE( 2679): appcore-efl.c: __do_app(470) > [APP 2679] Event: RESET State: CREATED
03-18 02:10:48.441+0900 D/APP_CORE( 2679): appcore-efl.c: __do_app(496) > [APP 2679] RESET
03-18 02:10:48.441+0900 D/LAUNCH  ( 2679): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
03-18 02:10:48.451+0900 D/CRASH_POPUP( 2679): crash.c: app_reset(226) > bundle_get_val - process_name:basicui
03-18 02:10:48.451+0900 D/CRASH_POPUP( 2679): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.example.basicui/bin/basicui
03-18 02:10:48.451+0900 D/PKGMGR_INFO( 2679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.451+0900 D/PKGMGR_INFO( 2679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.451+0900 D/PKGMGR_INFO( 2679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.451+0900 D/PKGMGR_INFO( 2679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-18 02:10:48.451+0900 I/CRASH_POPUP( 2679): crash.c: load_crash_process_popup(117) > Popup content: basicui has closed unexpectedly.
03-18 02:10:48.471+0900 E/EFL     ( 2679): eina_module<2679> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 02:10:48.491+0900 W/W_HOME  ( 2255): dbus.c: _dbus_message_recv_cb(178) > LCD on
03-18 02:10:48.491+0900 W/W_HOME  ( 2255): main.c: _lcd_on_cb(951) > LCD: off->on
03-18 02:10:48.491+0900 D/STARTER ( 2245): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-18 02:10:48.491+0900 W/STARTER ( 2245): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
03-18 02:10:48.491+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-18 02:10:48.491+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-18 02:10:48.491+0900 D/AUL_PAD ( 2187): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-18 02:10:48.491+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 02:10:48.491+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 02:10:48.491+0900 E/AUL_AMD ( 2144): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2144
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 2679, type 4 
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 2679
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
03-18 02:10:48.491+0900 E/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 356
03-18 02:10:48.491+0900 D/RESOURCED( 2340): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-18 02:10:48.491+0900 D/AUL     ( 2678): launch.c: app_request_to_launchpad(295) > launch request result : 2679
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: preference_get_int(1063) > preference_get_int(2265) : key(clock_font_color) error
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-18 02:10:48.491+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2265): preference.c: preference_get_int(1063) > preference_get_int(2265) : key(showdate) error
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Fri 18 Mar][1458234648]
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(857) > 
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[AM][1458234648]
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[2:10][1458234648]
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(871) > utc_time=2:10, utc_ampm=[2]AM
03-18 02:10:48.491+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>2:10<font_size=24><font=Tizen:style=Bold> AM</font></font_size></color>
03-18 02:10:48.521+0900 E/W_HOME  ( 2255): main.c: _window_focus_out_cb(885) > win[14680067], ev->win[14680071]
03-18 02:10:48.521+0900 D/APPS    ( 2255): apps_main.c: _window_focus_out_cb(308) >  focus out
03-18 02:10:48.521+0900 E/W_HOME  ( 2255): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-18 02:10:48.521+0900 D/APPS    ( 2255): apps_main.c: apps_main_pause(656) >  Pause starts
03-18 02:10:48.521+0900 D/APPS    ( 2255): apps_main.c: apps_main_pause(676) >  Pause done
03-18 02:10:48.521+0900 D/W_HOME  ( 2255): clock_event.c: _display_state_cb(194) > LCD: off->on
03-18 02:10:48.521+0900 D/W_HOME  ( 2255): clock_view.c: clock_view_event_handler(843) > event:40000 received
03-18 02:10:48.521+0900 D/W_HOME  ( 2255): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-18 02:10:48.521+0900 D/DATA_PROVIDER_MASTER( 2273): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-18 02:10:48.521+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
03-18 02:10:48.521+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-18 02:10:48.521+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
03-18 02:10:48.521+0900 D/NET_NFC_MANAGER( 2275): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
03-18 02:10:48.531+0900 D/LAUNCH  ( 2679): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
03-18 02:10:48.531+0900 I/APP_CORE( 2679): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
03-18 02:10:48.531+0900 I/APP_CORE( 2679): appcore-efl.c: __do_app(509) > [APP 2679] Initial Launching, call the resume_cb
03-18 02:10:48.531+0900 D/APP_CORE( 2679): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
03-18 02:10:48.531+0900 D/APP_CORE( 2679): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00006
03-18 02:10:48.531+0900 D/APP_CORE( 2679): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1e00006
03-18 02:10:48.541+0900 D/IDLE-CLOCK-DIGITAL( 2265): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
03-18 02:10:48.601+0900 D/APP_CORE( 2679): appcore.c: __prt_ltime(183) > [APP 2679] first idle after reset: 202 msec
03-18 02:10:48.611+0900 D/APP_CORE( 2679): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1e00006 fully_obscured 0
03-18 02:10:48.611+0900 D/APP_CORE( 2679): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
03-18 02:10:48.611+0900 D/APP_CORE( 2679): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
03-18 02:10:48.611+0900 D/APP_CORE( 2679): appcore-efl.c: __do_app(470) > [APP 2679] Event: RESUME State: RUNNING
03-18 02:10:48.611+0900 D/LAUNCH  ( 2679): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
03-18 02:10:48.611+0900 D/LAUNCH  ( 2679): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
03-18 02:10:48.611+0900 D/LAUNCH  ( 2679): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
03-18 02:10:48.611+0900 D/APP_CORE( 2679): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
03-18 02:10:48.611+0900 E/APP_CORE( 2679): appcore-efl.c: __trm_app_info_send_socket(233) > access
03-18 02:10:48.611+0900 D/RESOURCED( 2340): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2679, type = 0
03-18 02:10:48.611+0900 D/RESOURCED( 2340): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2679
03-18 02:10:48.611+0900 I/RESOURCED( 2340): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 2679, oom : 200
03-18 02:10:48.611+0900 E/RESOURCED( 2340): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
03-18 02:10:48.611+0900 E/RESOURCED( 2340): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2679) didn't have any process list
03-18 02:10:48.611+0900 D/RESOURCED( 2340): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2679, appname = (null)
03-18 02:10:48.611+0900 D/RESOURCED( 2340): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2679
03-18 02:10:48.611+0900 D/AUL_AMD ( 2144): amd_launch.c: __e17_status_handler(1911) > pid(2679) status(3)
03-18 02:10:49.491+0900 D/AUL_AMD ( 2144): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
03-18 02:10:49.491+0900 D/RUA     ( 2144): rua.c: rua_add_history(179) > rua_add_history start
03-18 02:10:49.501+0900 D/RUA     ( 2144): rua.c: rua_add_history(247) > rua_add_history ok
03-18 02:10:54.291+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 02:10:54.301+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
03-18 02:10:54.301+0900 D/EFL     ( 2679): ecore_x<2679> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5674306 button=1
03-18 02:10:54.301+0900 D/EFL     ( 2679): ecore_x<2679> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5674313 button=1
03-18 02:10:54.301+0900 E/EFL     ( 2679): eina_module<2679> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 02:10:54.321+0900 D/AUL     ( 2679): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-18 02:10:54.321+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 22
03-18 02:10:54.321+0900 D/APP_CORE( 2679): appcore-efl.c: __after_loop(1062) > [APP 2679] PAUSE before termination
03-18 02:10:54.321+0900 E/W_HOME  ( 2255): main.c: _window_focus_in_cb(851) > win[14680067], ev->win[14680071]
03-18 02:10:54.321+0900 D/APPS    ( 2255): apps_main.c: _window_focus_in_cb(288) >  focus in
03-18 02:10:54.321+0900 E/W_HOME  ( 2255): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-18 02:10:54.321+0900 D/APPS    ( 2255): apps_main.c: apps_main_resume(693) >  Resume starts
03-18 02:10:54.321+0900 D/APPS    ( 2255): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-18 02:10:54.321+0900 E/efl-extension( 2255): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb84fd120, elm_scroller, _activated_obj : 0xb84fd120, activated : 1
03-18 02:10:54.351+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2679 pgid = 2679
03-18 02:10:54.351+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(123) > dead_pid(2679)
03-18 02:10:54.361+0900 D/AUL_PAD ( 2187): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-18 02:10:54.361+0900 I/AUL_PAD ( 2187): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-18 02:10:54.361+0900 I/AUL_PAD ( 2187): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-18 02:10:54.361+0900 D/W_HOME  ( 2255): main.c: _dead_cb(542) > PID(2679) is dead
03-18 02:10:54.361+0900 E/W_HOME  ( 2255): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-18 02:10:54.361+0900 D/STARTER ( 2245): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2679)
03-18 02:10:54.361+0900 I/AUL_AMD ( 2144): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2679
03-18 02:10:54.361+0900 D/AUL_AMD ( 2144): amd_key.c: _unregister_key_event(161) > ===key stack===
03-18 02:10:54.361+0900 D/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-18 02:10:54.361+0900 E/AUL     ( 2144): simple_util.c: __trm_app_info_send_socket(264) > access
03-18 02:10:56.141+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 02:10:56.201+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5676159 button=1
03-18 02:10:56.201+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [189,234]
03-18 02:10:56.311+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(113) > pid(2679)
03-18 02:10:56.311+0900 D/AUL_AMD ( 2144): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-18 02:10:56.401+0900 D/APPS    ( 2255): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-18 02:10:56.601+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5676583 button=1
03-18 02:10:56.601+0900 D/APPS    ( 2255): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-18 02:10:56.601+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [189,165]
03-18 02:10:56.991+0900 I/GESTURE ( 2032): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-18 02:10:57.051+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5677036 button=1
03-18 02:10:57.051+0900 D/APPS    ( 2255): scroller.c: _mouse_down_cb(100) >  Mouse is down [103,200]
03-18 02:10:57.051+0900 D/APPS    ( 2255): item.c: _down_cb(381) >  Down (basicui,0xb870b040) (103, 200), item pos(6,163,166,144)
03-18 02:10:57.051+0900 E/APPS    ( 2255): item.c: _down_cb(425) >  longpress edit mode disable
03-18 02:10:57.051+0900 W/APPS    ( 2255): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-18 02:10:57.121+0900 D/EFL     ( 2255): ecore_x<2255> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5677132 button=1
03-18 02:10:57.121+0900 D/APPS    ( 2255): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-18 02:10:57.121+0900 D/APPS    ( 2255): scroller.c: _mouse_up_cb(111) >  Mouse is up [103,200]
03-18 02:10:57.121+0900 D/APPS    ( 2255): item.c: _up_cb(573) >  Up (basicui,0xb870b040) (103, 200), item pos(6,163,166,144)
03-18 02:10:57.121+0900 E/APPS    ( 2255): item.c: _clicked_cb(65) >  Clicked
03-18 02:10:57.121+0900 E/APPS    ( 2255): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-18 02:10:57.121+0900 D/APPS    ( 2255): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-18 02:10:57.121+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 02:10:57.121+0900 D/APP_SVC ( 2255): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-18 02:10:57.121+0900 D/APP_SVC ( 2255): appsvc.c: __set_bundle(161) > __set_bundle
03-18 02:10:57.121+0900 D/W_HOME  ( 2255): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-18 02:10:57.121+0900 D/W_HOME  ( 2255): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-18 02:10:57.121+0900 D/APP_SVC ( 2255): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-18 02:10:57.121+0900 D/AUL     ( 2255): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-18 02:10:57.121+0900 D/AUL     ( 2255): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(495) > __request_handler: 0
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-18 02:10:57.121+0900 E/AUL_AMD ( 2144): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1785) > process_pool: false
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-18 02:10:57.121+0900 D/AUL_AMD ( 2144): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-18 02:10:57.121+0900 D/AUL     ( 2144): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-18 02:10:57.121+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-18 02:10:57.121+0900 D/AUL_PAD ( 2187): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-18 02:10:57.121+0900 D/AUL_PAD ( 2187): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2708 /opt/usr/apps/org.example.basicui/bin/basicui
03-18 02:10:57.121+0900 D/AUL_PAD ( 2187): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-18 02:10:57.121+0900 D/AUL_PAD ( 2708): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-18 02:10:57.121+0900 D/AUL_PAD ( 2708): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-18 02:10:57.121+0900 D/AUL_PAD ( 2708): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-18 02:10:57.131+0900 D/AUL_PAD ( 2708): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-18 02:10:57.131+0900 D/LAUNCH  ( 2708): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-18 02:10:57.141+0900 I/efl-extension( 2708): efl_extension.c: eext_mod_init(39) > Init
03-18 02:10:57.141+0900 I/CAPI_APPFW_APPLICATION( 2708): app_main.c: ui_app_main(701) > app_efl_main
03-18 02:10:57.141+0900 D/LAUNCH  ( 2708): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
03-18 02:10:57.151+0900 D/APP_CORE( 2708): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
03-18 02:10:57.151+0900 D/AUL     ( 2708): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 2708 is org.example.basicui
03-18 02:10:57.151+0900 D/APP_CORE( 2708): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
03-18 02:10:57.151+0900 D/APP_CORE( 2708): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
03-18 02:10:57.151+0900 D/AUL     ( 2708): app_sock.c: __create_server_sock(136) > pg path - already exists
03-18 02:10:57.151+0900 D/LAUNCH  ( 2708): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
03-18 02:10:57.151+0900 I/CAPI_APPFW_APPLICATION( 2708): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
03-18 02:10:57.181+0900 E/EFL     ( 2708): eina_module<2708> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-18 02:10:57.181+0900 E/EFL     ( 2708): ecore_evas<2708> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-18 02:10:57.191+0900 W/CRASH_MANAGER( 2657): worker.c: worker_job(1189) > 1102708626173145823465
