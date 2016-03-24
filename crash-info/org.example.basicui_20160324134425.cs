S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: basicui
PID: 9247
Date: 2016-03-24 13:44:25+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xffffff97

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfe01730, esi = 0xbfe01640
ebp = 0xbfe01678, esp = 0xbfe01638
eax = 0xb45fe997, ebx = 0xb45fe9f8
ecx = 0xb967fc48, edx = 0xffffff97
eip = 0xb755169a

Memory Information
MemTotal:      124 KB
MemFree:        26 KB
Buffers:        15 KB
Cached:     163580 KB
VmPeak:      59940 KB
VmSize:      59940 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7624 KB
VmRSS:        7624 KB
VmData:       2184 KB
VmStk:         980 KB
VmExe:          28 KB
VmLib:       31504 KB
VmPTE:          52 KB
VmSwap:          0 KB

Maps Information
b3fd5000 b3fd8000 r-xp /usr/lib/libdri2.so.0.0.0
b3fd9000 b3fe4000 r-xp /usr/lib/libdrm.so.2.4.0
b3fe5000 b3fee000 r-xp /usr/lib/libtbm.so.1.0.0
b3fef000 b3ff6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3ff7000 b4000000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4001000 b4008000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4009000 b400f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4010000 b4018000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4019000 b401d000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b401e000 b403b000 r-xp /usr/lib/libtts.so
b403c000 b4180000 r-xp /usr/lib/libcairo.so.2.11200.14
b4184000 b419c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b419d000 b41be000 r-xp /usr/lib/libefl-extension.so.0.1.0
b41bf000 b41cf000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b41d0000 b41db000 r-xp /lib/libnss_files-2.13.so
b441c000 b4443000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4444000 b4469000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b446a000 b458b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b459b000 b45d1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b45d3000 b45d6000 r-xp /usr/lib/libiniparser.so.0
b45d8000 b45e2000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45e3000 b45ec000 r-xp /usr/lib/libappsvc.so.0.1.0
b45ed000 b45f0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45f1000 b45f3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45f4000 b45fa000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b45fb000 b45fe000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b45ff000 b4605000 r-xp /usr/lib/libogg.so.0.7.1
b4606000 b4631000 r-xp /usr/lib/libvorbis.so.0.4.3
b4632000 b471d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b472b000 b472d000 r-xp /usr/lib/libXau.so.6.0.0
b472e000 b478e000 r-xp /usr/lib/libssl.so.1.0.0
b4793000 b47c4000 r-xp /usr/lib/libidn.so.11.5.44
b47c5000 b47d5000 r-xp /usr/lib/libcares.so.2.1.0
b47d6000 b483f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4845000 b484f000 r-xp /usr/lib/libsensord-share.so
b4850000 b4876000 r-xp /lib/libexpat.so.1.5.2
b4878000 b489f000 r-xp /usr/lib/libpng12.so.0.50.0
b48a0000 b48c0000 r-xp /usr/lib/libxcb.so.1.1.0
b48c1000 b4930000 r-xp /usr/lib/libcurl.so.4.3.0
b4932000 b493d000 r-xp /usr/lib/libethumb.so.1.7.99
b5e9d000 b5f75000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f81000 b5f84000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f85000 b5f9b000 r-xp /usr/lib/libremix.so.0.0.0
b5f9c000 b5f9e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f9f000 b5fcb000 r-xp /usr/lib/liblua-5.1.so
b5fcc000 b5fd6000 r-xp /usr/lib/libembryo.so.1.7.99
b5fd7000 b601d000 r-xp /usr/lib/libjpeg.so.8.0.2
b602e000 b604c000 r-xp /usr/lib/libsensor.so.1.1.0
b604e000 b60d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b60d5000 b6109000 r-xp /usr/lib/libfontconfig.so.1.5.0
b610b000 b6166000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6168000 b617e000 r-xp /usr/lib/libfribidi.so.0.3.1
b617f000 b620b000 r-xp /usr/lib/libfreetype.so.6.11.3
b620f000 b6212000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6213000 b6219000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b621a000 b6220000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6222000 b6233000 r-xp /usr/lib/libXext.so.6.4.0
b6234000 b6368000 r-xp /usr/lib/libX11.so.6.3.0
b636c000 b6371000 r-xp /usr/lib/libXtst.so.6.1.0
b6372000 b637a000 r-xp /usr/lib/libXrender.so.1.3.0
b637b000 b6384000 r-xp /usr/lib/libXrandr.so.2.2.0
b6385000 b6387000 r-xp /usr/lib/libXinerama.so.1.0.0
b6388000 b6396000 r-xp /usr/lib/libXi.so.6.1.0
b6397000 b639b000 r-xp /usr/lib/libXfixes.so.3.1.0
b639c000 b639e000 r-xp /usr/lib/libXgesture.so.7.0.0
b639f000 b63a1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b63a2000 b63a4000 r-xp /usr/lib/libXdamage.so.1.1.0
b63a5000 b63ae000 r-xp /usr/lib/libXcursor.so.1.0.2
b63af000 b63da000 r-xp /usr/lib/libecore_con.so.1.7.99
b63dc000 b63e4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63e5000 b63f0000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63f1000 b63f7000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63f8000 b6419000 r-xp /usr/lib/libefreet.so.1.7.99
b641b000 b6427000 r-xp /usr/lib/libedbus.so.1.7.99
b6428000 b6587000 r-xp /usr/lib/libicuuc.so.51.1
b6595000 b679e000 r-xp /usr/lib/libicui18n.so.51.1
b67a7000 b6844000 r-xp /usr/lib/libedje.so.1.7.99
b6846000 b6857000 r-xp /usr/lib/libecore_input.so.1.7.99
b6858000 b685f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6860000 b6886000 r-xp /usr/lib/libeet.so.1.7.99
b688f000 b69b7000 r-xp /usr/lib/libevas.so.1.7.99
b69d4000 b6a07000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6a09000 b6a4d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a4f000 b6c49000 r-xp /usr/lib/libelementary.so.1.7.99
b6c5a000 b6c60000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c61000 b6c65000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c69000 b6c6a000 r-xp /usr/lib/libjournal.so.0.1.0
b6c6b000 b6db3000 r-xp /usr/lib/libxml2.so.2.7.8
b6dba000 b6dcd000 r-xp /lib/libresolv-2.13.so
b6dd1000 b6dee000 r-xp /lib/libz.so.1.2.5
b6def000 b6df2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6df3000 b6df8000 r-xp /usr/lib/libffi.so.5.0.10
b6df9000 b6dfa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dfc000 b6e00000 r-xp /lib/libattr.so.1.1.0
b6e01000 b7013000 r-xp /usr/lib/libcrypto.so.1.0.0
b702e000 b704f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7050000 b7078000 r-xp /lib/libm-2.13.so
b707a000 b70d5000 r-xp /usr/lib/libeina.so.1.7.99
b70d8000 b70e3000 r-xp /usr/lib/libvconf.so.0.2.45
b70e4000 b70e7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70e8000 b7136000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7137000 b7298000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b729c000 b72a3000 r-xp /lib/librt-2.13.so
b72a6000 b72ad000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b72af000 b72c9000 r-xp /lib/libgcc_s-4.6.4.so.1
b72ca000 b72d2000 r-xp /lib/libcrypt-2.13.so
b72fb000 b72ff000 r-xp /lib/libcap.so.2.21
b7300000 b7302000 r-xp /usr/lib/libiri.so
b7304000 b7330000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7331000 b7351000 r-xp /usr/lib/libecore.so.1.7.99
b7360000 b7369000 r-xp /usr/lib/libxdgmime.so.1.1.0
b736a000 b748d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b748e000 b74a1000 r-xp /usr/lib/libail.so.0.1.0
b74a3000 b74c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b74c9000 b74d3000 r-xp /lib/libunwind.so.8.0.1
b74dd000 b764e000 r-xp /lib/libc-2.13.so
b7654000 b769e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b769f000 b76a4000 r-xp /usr/lib/libbundle.so.0.1.22
b76a5000 b76a8000 r-xp /lib/libdl-2.13.so
b76ab000 b76b0000 r-xp /usr/lib/libsmack.so.1.0.0
b76b1000 b7759000 r-xp /usr/lib/libsqlite3.so.0.8.6
b775c000 b7776000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7777000 b778e000 r-xp /lib/libpthread-2.13.so
b7792000 b7795000 r-xp /usr/lib/libdlog.so.0.0.0
b7796000 b77a6000 r-xp /usr/lib/libaul.so.0.1.0
b77a8000 b77ae000 r-xp /usr/lib/libappcore-common.so.1.1
b77af000 b77b4000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b6000 b77bb000 r-xp /usr/lib/libsys-assert.so
b77be000 b77dc000 r-xp /lib/ld-2.13.so
b77dc000 b77dd000 r-xp [vdso]
b77df000 b77e6000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:9247)
Call Stack Count: 4
 0: strcat + 0x1a (0xb755169a) [/lib/libc.so.6] + 0x7469a
 1: main + 0x316 (0xb45fc526) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1526
 2: (0xb77e25b1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77e25b1
 3: __libc_start_main + 0xf3 (0xb74f60f3) [/lib/libc.so.6] + 0x190f3
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
asicui-1.0.0-i386.tpk_408002989] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 13:44:01.032+0900 D/W_HOME  ( 2311): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.basicui key:end val:ok
03-24 13:44:01.032+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 13:44:01.032+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 13:44:01.032+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989 / coretpk / org.example.basicui / end / ok
03-24 13:44:01.032+0900 D/PKGMGR  ( 2311): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 13:44:01.032+0900 D/APPS    ( 2311): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.basicui
03-24 13:44:01.032+0900 D/APPS    ( 2311): pkgmgr.c: _end(651) >  Package(org.example.basicui) : key(update) - val(ok)
03-24 13:44:01.032+0900 D/APPS    ( 2311): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.basicui]
03-24 13:44:01.052+0900 D/APPS    ( 2311): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.basicui]'s item object
03-24 13:44:01.052+0900 D/APPS    ( 2311): db.c: apps_db_remove_item(404) >  Remove the item[org.example.basicui]
03-24 13:44:01.052+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989 / coretpk / org.example.basicui / end / ok
03-24 13:44:01.052+0900 D/PKGMGR  ( 2173): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 13:44:01.052+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989 / coretpk / org.example.basicui / end / ok
03-24 13:44:01.052+0900 D/PKGMGR  ( 2226): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.basicui-1.0.0-i386.tpk_408002989] pkg_type[coretpk] pkgid[org.example.basicui]key[end] val[ok]
03-24 13:44:01.052+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.basicui), key(end), value(ok)
03-24 13:44:01.052+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
03-24 13:44:01.052+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
03-24 13:44:01.052+0900 D/AUL_AMD ( 2226): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.basicui, comp:ui, type:rpm
03-24 13:44:01.052+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 13:44:01.052+0900 D/PKGMGR  ( 2226): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 13:44:01.052+0900 D/rpm-installer( 9143): coretpk-installer.c: _coretpk_installer_prepare_package_install(2872) > success
03-24 13:44:01.052+0900 D/rpm-installer( 9143): rpm-appcore-intf.c: main(224) > sync() start
03-24 13:44:01.072+0900 E/PKGMGR_INFO( 2173): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
03-24 13:44:01.072+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 13:44:01.072+0900 D/PKGMGR  ( 2173): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 13:44:01.072+0900 D/rpm-installer( 9143): rpm-appcore-intf.c: main(226) > sync() end
03-24 13:44:01.072+0900 D/rpm-installer( 9143): rpm-appcore-intf.c: main(245) > ------------------------------------------------
03-24 13:44:01.072+0900 D/rpm-installer( 9143): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
03-24 13:44:01.072+0900 D/rpm-installer( 9143): rpm-appcore-intf.c: main(247) > ------------------------------------------------
03-24 13:44:01.072+0900 D/APPS    ( 2311): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-24 13:44:01.072+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-24 13:44:01.082+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-24 13:44:01.082+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-24 13:44:01.082+0900 D/APPS    ( 2311): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.basicui]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-24 13:44:01.082+0900 D/PKGMGR_SERVER( 9134): pkgmgr-server.c: sighandler(326) > child exit [9143]
03-24 13:44:01.082+0900 D/PKGMGR_SERVER( 9134): pkgmgr-server.c: sighandler(341) > child NORMAL exit [9143]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
03-24 13:44:01.082+0900 D/BADGE   ( 2335): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 13:44:01.082+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
03-24 13:44:01.082+0900 E/DATA_PROVIDER_MASTER( 2335): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2335, fd: -1
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2335), fd: -1
03-24 13:44:01.082+0900 D/COM_CORE( 2311): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 32 (recv_fd: -1)
03-24 13:44:01.102+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-24 13:44:01.102+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c09d18 is terminated (NIL packet)
03-24 13:44:01.102+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-24 13:44:01.102+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 97 bytes
03-24 13:44:01.102+0900 D/APPS    ( 2311): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.basicui], name[basicui]
03-24 13:44:01.102+0900 D/COM_CORE( 2335): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
03-24 13:44:01.102+0900 D/DATA_PROVIDER_MASTER( 2335): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb8c0dc08 is terminated (NIL packet)
03-24 13:44:01.102+0900 D/DATA_PROVIDER_MASTER( 2335): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
03-24 13:44:01.102+0900 D/APPS    ( 2311): item.c: item_create(819) >  Icon size after ea_effect (124:127)
03-24 13:44:01.102+0900 D/BADGE   ( 2311): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.basicui'], count[0]
03-24 13:44:01.102+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
03-24 13:44:01.102+0900 D/APPS    ( 2311): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.basicui]'s ordering : 1
03-24 13:44:01.102+0900 D/APPS    ( 2311): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
03-24 13:44:01.112+0900 D/APPS    ( 2311): db.c: apps_db_insert_item(345) >  Insert the item[org.example.basicui:1]
03-24 13:44:01.122+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
03-24 13:44:01.122+0900 D/PKGMGR  ( 2311): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
03-24 13:44:01.992+0900 D/PKGMGR_SERVER( 9134): pkgmgr-server.c: exit_server(724) > exit_server Start
03-24 13:44:01.992+0900 D/PKGMGR_SERVER( 9134): pkgmgr-server.c: main(1516) > Quit main loop.
03-24 13:44:01.992+0900 D/PKGMGR_SERVER( 9134): pkgmgr-server.c: main(1524) > package manager server terminated.
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-24 13:44:05.912+0900 D/AUL     ( 2226): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 9200, pid = 9202
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-24 13:44:05.912+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 13:44:05.912+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-24 13:44:05.922+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-24 13:44:05.922+0900 D/AUL_PAD ( 2234): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-24 13:44:05.922+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 9203 /opt/usr/apps/org.example.basicui/bin/basicui
03-24 13:44:05.922+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
03-24 13:44:05.922+0900 D/AUL_PAD ( 9203): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
03-24 13:44:05.922+0900 D/LAUNCH  ( 9203): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-24 13:44:05.932+0900 I/efl-extension( 9203): efl_extension.c: eext_mod_init(39) > Init
03-24 13:44:05.952+0900 W/CRASH_MANAGER( 9061): worker.c: worker_job(1189) > 11092036261731458794645
03-24 13:44:05.962+0900 I/AUL_PAD ( 2234): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9203 pgid = 9203
03-24 13:44:05.962+0900 I/AUL_PAD ( 2234): sigchild.h: __sigchild_action(123) > dead_pid(9203)
03-24 13:44:05.962+0900 D/AUL_PAD ( 2234): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-24 13:44:05.962+0900 I/AUL_PAD ( 2234): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-24 13:44:05.962+0900 I/AUL_PAD ( 2234): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-24 13:44:05.962+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:05.962+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:05.962+0900 D/STARTER ( 2303): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 9203)
03-24 13:44:05.962+0900 D/W_HOME  ( 2311): main.c: _dead_cb(542) > PID(9203) is dead
03-24 13:44:05.962+0900 E/W_HOME  ( 2311): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-24 13:44:06.062+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.062+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.162+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.162+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.262+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.262+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.362+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.362+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.472+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.472+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.572+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.572+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.672+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.672+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.792+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.792+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.892+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.892+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:06.992+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:06.992+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.092+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.092+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.142+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.142+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.142+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.142+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.152+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.152+0900 D/PKGMGR_INFO( 9061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
03-24 13:44:07.202+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.202+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.302+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.302+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.402+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.402+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.502+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.502+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.602+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.602+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.712+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.712+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.812+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(544) > error founded when being launched with 9203
03-24 13:44:07.812+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:07.922+0900 E/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(566) > process launched, but cmdline not changed
03-24 13:44:07.922+0900 D/AUL_PAD ( 2234): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
03-24 13:44:07.922+0900 D/AUL_PAD ( 2234): sigchild.h: __send_app_launch_signal(112) > send launch signal done
03-24 13:44:07.922+0900 D/AUL_PAD ( 2234): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
03-24 13:44:07.922+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 13:44:07.922+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 13:44:07.922+0900 I/AUL_AMD ( 2226): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9203
03-24 13:44:07.922+0900 D/AUL_AMD ( 2226): amd_key.c: _unregister_key_event(161) > ===key stack===
03-24 13:44:07.922+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 13:44:07.922+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 13:44:07.922+0900 D/RESOURCED( 2402): proc-noti.c: recv_str(87) > [recv_str,87] str is null
03-24 13:44:07.922+0900 D/RESOURCED( 2402): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2226
03-24 13:44:07.922+0900 D/RESOURCED( 2402): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 9203, type 4 
03-24 13:44:07.922+0900 E/RESOURCED( 2402): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/9203/oom_score_adj failed
03-24 13:44:07.922+0900 E/RESOURCED( 2402): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 9203
03-24 13:44:07.922+0900 D/RESOURCED( 2402): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
03-24 13:44:08.922+0900 D/AUL_AMD ( 2226): amd_launch.c: __grab_timeout_handler(1212) > pid(9203) ecore_x_pointer_ungrab
03-24 13:44:08.922+0900 D/AUL_AMD ( 2226): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
03-24 13:44:08.922+0900 D/RUA     ( 2226): rua.c: rua_add_history(179) > rua_add_history start
03-24 13:44:08.922+0900 D/RUA     ( 2226): rua.c: rua_add_history(247) > rua_add_history ok
03-24 13:44:16.662+0900 E/AUL_AMD ( 2226): amd_status.c: __lcd_status_cb(679) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
03-24 13:44:16.662+0900 W/W_HOME  ( 2311): dbus.c: _dbus_message_recv_cb(178) > LCD on
03-24 13:44:16.662+0900 W/W_HOME  ( 2311): main.c: _lcd_on_cb(951) > LCD: off->on
03-24 13:44:16.662+0900 D/STARTER ( 2303): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
03-24 13:44:16.662+0900 W/STARTER ( 2303): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
03-24 13:44:16.662+0900 D/STARTER ( 2303): hw_key_w.c: _key_press_cb(1107) > [_key_press_cb:1107] _key_press_cb : XF86PowerOff Pressed
03-24 13:44:16.662+0900 W/STARTER ( 2303): hw_key_w.c: _key_press_cb(1112) > [_key_press_cb:1112] POWER Key is pressed
03-24 13:44:16.662+0900 W/STARTER ( 2303): hw_key_w.c: _key_press_cb(1118) > [_key_press_cb:1118] LCD state : 3
03-24 13:44:16.662+0900 E/STARTER ( 2303): hw_key_w.c: _key_press_cb(1127) > [_key_press_cb:1127] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
03-24 13:44:16.662+0900 W/STARTER ( 2303): hw_key_w.c: _key_press_cb(1130) > [_key_press_cb:1130] Simple Clock state : 0
03-24 13:44:16.662+0900 W/STARTER ( 2303): hw_key_w.c: _key_press_cb(1135) > [_key_press_cb:1135] powerkey count : 1
03-24 13:44:16.662+0900 D/STARTER ( 2303): hw_key_w.c: _key_press_cb(1149) > [_key_press_cb:1149] create long press timer
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: preference_get_int(1063) > preference_get_int(2313) : key(clock_font_color) error
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
03-24 13:44:16.662+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2313): preference.c: preference_get_int(1063) > preference_get_int(2313) : key(showdate) error
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: clock_view_set_info_time(849) > show_date:1
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Thu 24 Mar][1458794656]
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: clock_view_set_info_time(857) > 
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1458794656]
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[1:44][1458794656]
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: clock_view_set_info_time(871) > utc_time=1:44, utc_ampm=[2]PM
03-24 13:44:16.662+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>1:44<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
03-24 13:44:16.672+0900 D/NET_NFC_MANAGER( 2338): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
03-24 13:44:16.672+0900 D/NET_NFC_MANAGER( 2338): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
03-24 13:44:16.672+0900 D/DATA_PROVIDER_MASTER( 2335): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
03-24 13:44:16.672+0900 D/W_HOME  ( 2311): clock_event.c: _display_state_cb(194) > LCD: off->on
03-24 13:44:16.672+0900 D/W_HOME  ( 2311): clock_view.c: clock_view_event_handler(843) > event:40000 received
03-24 13:44:16.672+0900 D/W_HOME  ( 2311): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
03-24 13:44:16.672+0900 D/NET_NFC_MANAGER( 2338): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
03-24 13:44:16.672+0900 D/NET_NFC_MANAGER( 2338): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
03-24 13:44:16.672+0900 D/IDLE-CLOCK-DIGITAL( 2313): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
03-24 13:44:16.702+0900 D/STARTER ( 2303): hw_key_w.c: _key_release_cb(1038) > [_key_release_cb:1038] _key_release_cb : XF86PowerOff Released
03-24 13:44:16.702+0900 W/STARTER ( 2303): hw_key_w.c: _key_release_cb(1043) > [_key_release_cb:1043] POWER Key is released
03-24 13:44:16.702+0900 D/STARTER ( 2303): hw_key_w.c: _key_release_cb(1049) > [_key_release_cb:1049] delete long press timer
03-24 13:44:16.702+0900 D/STARTER ( 2303): hw_key_w.c: _key_release_cb(1075) > [_key_release_cb:1075] lcd off --> [0.400000]sec timer
03-24 13:44:17.112+0900 W/STARTER ( 2303): hw_key_w.c: _powerkey_timer_cb(777) > [_powerkey_timer_cb:777] _powerkey_timer_cb, powerkey count[1]
03-24 13:44:17.112+0900 E/STARTER ( 2303): hw_key_w.c: _powerkey_timer_cb(796) > [SECURE_LOG] [_powerkey_timer_cb:796] Failed to get vconfkey[memory/setup_wizard/state]
03-24 13:44:17.112+0900 E/STARTER ( 2303): hw_key_w.c: _powerkey_timer_cb(825) > [SECURE_LOG] [_powerkey_timer_cb:825] Failed to get vconfkey[db/wms/safety_enable]
03-24 13:44:17.112+0900 W/STARTER ( 2303): hw_key_w.c: _powerkey_timer_cb(891) > [_powerkey_timer_cb:891] just turn on LCD by powerkey.. starter ignore powerkey operation
03-24 13:44:17.952+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:17.952+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
03-24 13:44:17.952+0900 D/EFL     ( 8779): ecore_x<8779> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16699957 button=1
03-24 13:44:17.952+0900 D/EFL     ( 8779): ecore_x<8779> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16699961 button=1
03-24 13:44:17.952+0900 E/EFL     ( 8779): eina_module<8779> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
03-24 13:44:18.012+0900 D/AUL     ( 8779): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
03-24 13:44:18.012+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 22
03-24 13:44:18.012+0900 D/APP_CORE( 8779): appcore-efl.c: __after_loop(1062) > [APP 8779] PAUSE before termination
03-24 13:44:18.012+0900 E/W_HOME  ( 2311): main.c: _window_focus_in_cb(851) > win[25165827], ev->win[25165831]
03-24 13:44:18.012+0900 D/APPS    ( 2311): apps_main.c: _window_focus_in_cb(288) >  focus in
03-24 13:44:18.012+0900 E/W_HOME  ( 2311): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
03-24 13:44:18.012+0900 D/APPS    ( 2311): apps_main.c: apps_main_resume(693) >  Resume starts
03-24 13:44:18.012+0900 D/APPS    ( 2311): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
03-24 13:44:18.012+0900 E/efl-extension( 2311): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb9851368, elm_scroller, _activated_obj : 0xb9851368, activated : 1
03-24 13:44:18.052+0900 I/AUL_PAD ( 2234): sigchild.h: __launchpad_sig_child(142) > dead_pid = 8779 pgid = 8779
03-24 13:44:18.052+0900 I/AUL_PAD ( 2234): sigchild.h: __sigchild_action(123) > dead_pid(8779)
03-24 13:44:18.052+0900 D/AUL_PAD ( 2234): sigchild.h: __send_app_dead_signal(81) > send dead signal done
03-24 13:44:18.052+0900 I/AUL_PAD ( 2234): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
03-24 13:44:18.052+0900 I/AUL_PAD ( 2234): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
03-24 13:44:18.062+0900 D/W_HOME  ( 2311): main.c: _dead_cb(542) > PID(8779) is dead
03-24 13:44:18.062+0900 E/W_HOME  ( 2311): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
03-24 13:44:18.062+0900 D/STARTER ( 2303): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 8779)
03-24 13:44:18.062+0900 I/AUL_AMD ( 2226): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8779
03-24 13:44:18.062+0900 D/AUL_AMD ( 2226): amd_key.c: _unregister_key_event(161) > ===key stack===
03-24 13:44:18.062+0900 D/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
03-24 13:44:18.062+0900 E/AUL     ( 2226): simple_util.c: __trm_app_info_send_socket(264) > access
03-24 13:44:20.012+0900 D/AUL_AMD ( 2226): amd_status.c: __app_terminate_timer_cb(113) > pid(8779)
03-24 13:44:20.012+0900 D/AUL_AMD ( 2226): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
03-24 13:44:20.612+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:20.662+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16702626 button=1
03-24 13:44:20.662+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [170,202]
03-24 13:44:20.662+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (basicui,0xb9868708) (170, 202), item pos(41,1,280,390)
03-24 13:44:20.662+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:20.682+0900 W/APPS    ( 2311): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 13:44:20.832+0900 D/APPS    ( 2311): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 13:44:20.832+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:21.002+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16703016 button=1
03-24 13:44:21.002+0900 D/APPS    ( 2311): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 13:44:21.002+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [17,202]
03-24 13:44:21.002+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (basicui,0xb9868708) (17, 202), item pos(41,1,280,390)
03-24 13:44:21.022+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:21.022+0900 D/APPS    ( 2311): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 13:44:21.882+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:21.932+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16703895 button=1
03-24 13:44:21.932+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [243,169]
03-24 13:44:21.932+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (basicui,0xb9868708) (243, 169), item pos(41,1,280,390)
03-24 13:44:21.932+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:21.942+0900 W/APPS    ( 2311): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 13:44:22.002+0900 D/APPS    ( 2311): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 13:44:22.032+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:22.182+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16704191 button=1
03-24 13:44:22.182+0900 D/APPS    ( 2311): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 13:44:22.182+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [41,169]
03-24 13:44:22.182+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (basicui,0xb9868708) (41, 169), item pos(41,1,280,390)
03-24 13:44:22.192+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:22.192+0900 D/APPS    ( 2311): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 13:44:22.612+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:22.672+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16704657 button=1
03-24 13:44:22.672+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [85,169]
03-24 13:44:22.672+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (basicui,0xb9868708) (85, 169), item pos(41,1,280,390)
03-24 13:44:22.672+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:22.672+0900 W/APPS    ( 2311): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 13:44:22.762+0900 D/APPS    ( 2311): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 13:44:22.762+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:22.932+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16704923 button=1
03-24 13:44:22.932+0900 D/APPS    ( 2311): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 13:44:22.932+0900 D/APPS    ( 2311): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-24 13:44:22.932+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [350,163]
03-24 13:44:22.932+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (basicui,0xb9868708) (350, 163), item pos(337,1,280,390)
03-24 13:44:22.932+0900 D/APPS    ( 2311): item.c: _up_cb(634) >  cur_x,cur_y: [477, 196]
03-24 13:44:22.932+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:22.932+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:22.932+0900 D/APPS    ( 2311): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 13:44:23.132+0900 D/APPS    ( 2311): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
03-24 13:44:23.452+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:23.502+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16705461 button=1
03-24 13:44:23.502+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [129,182]
03-24 13:44:23.502+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (Settings,0xb9948ee8) (129, 182), item pos(41,1,280,390)
03-24 13:44:23.502+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:23.522+0900 W/APPS    ( 2311): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 13:44:23.602+0900 D/APPS    ( 2311): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 13:44:23.622+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:23.752+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16705762 button=1
03-24 13:44:23.752+0900 D/APPS    ( 2311): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 13:44:23.752+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [314,177]
03-24 13:44:23.752+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (Settings,0xb9948ee8) (314, 177), item pos(41,1,280,390)
03-24 13:44:23.772+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:23.772+0900 D/APPS    ( 2311): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 13:44:24.182+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:24.262+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16706247 button=1
03-24 13:44:24.262+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [268,174]
03-24 13:44:24.262+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (Settings,0xb9948ee8) (268, 174), item pos(41,1,280,390)
03-24 13:44:24.262+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:24.262+0900 W/APPS    ( 2311): item.c: _anim_item_pressed_cb(1046) >  item is pressed
03-24 13:44:24.352+0900 D/APPS    ( 2311): scroller.c: _drag_start_cb(149) >  start to drag the scroller animation
03-24 13:44:24.352+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:24.532+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16706537 button=1
03-24 13:44:24.532+0900 D/APPS    ( 2311): scroller.c: _drag_stop_cb(169) >  stop to drag the scroller animation
03-24 13:44:24.532+0900 D/APPS    ( 2311): scroller.c: _anim_start_cb(122) >  start the scroller animation
03-24 13:44:24.532+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [46,167]
03-24 13:44:24.532+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (Settings,0xb9948ee8) (46, 167), item pos(-195,1,280,390)
03-24 13:44:24.532+0900 D/APPS    ( 2311): item.c: _up_cb(634) >  cur_x,cur_y: [-55, 196]
03-24 13:44:24.542+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:24.542+0900 W/APPS    ( 2311): item.c: _anim_item_released_cb(1075) >  item is released
03-24 13:44:24.542+0900 D/APPS    ( 2311): item.c: _anim_move_item_to_empty_position(156) >  item_inner was not unset
03-24 13:44:24.722+0900 D/APPS    ( 2311): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
03-24 13:44:25.242+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
03-24 13:44:25.252+0900 I/GESTURE ( 2067): gesture.c: GestureRecognize_GroupTap(734) > [GroupTap][F] num_pressed(=0) != prev_num_pressed(=0) OR 0 finger tap event was not grabbed/selected !
03-24 13:44:25.252+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=16707259 button=1
03-24 13:44:25.252+0900 D/EFL     ( 2311): ecore_x<2311> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=16707265 button=1
03-24 13:44:25.252+0900 D/APPS    ( 2311): scroller.c: _mouse_down_cb(100) >  Mouse is down [156,163]
03-24 13:44:25.252+0900 D/APPS    ( 2311): item.c: _down_cb(381) >  Down (basicui,0xb9868708) (156, 163), item pos(41,1,280,390)
03-24 13:44:25.252+0900 E/APPS    ( 2311): item.c: _down_cb(425) >  longpress edit mode disable
03-24 13:44:25.252+0900 D/APPS    ( 2311): scroller.c: _mouse_up_cb(111) >  Mouse is up [156,163]
03-24 13:44:25.252+0900 D/APPS    ( 2311): item.c: _up_cb(573) >  Up (basicui,0xb9868708) (156, 163), item pos(41,1,280,390)
03-24 13:44:25.252+0900 E/APPS    ( 2311): item.c: _clicked_cb(65) >  Clicked
03-24 13:44:25.252+0900 E/APPS    ( 2311): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-24 13:44:25.252+0900 D/APPS    ( 2311): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
03-24 13:44:25.252+0900 D/APP_SVC ( 2311): appsvc.c: __set_bundle(161) > __set_bundle
03-24 13:44:25.252+0900 D/APP_SVC ( 2311): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
03-24 13:44:25.252+0900 D/APP_SVC ( 2311): appsvc.c: __set_bundle(161) > __set_bundle
03-24 13:44:25.252+0900 D/W_HOME  ( 2311): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
03-24 13:44:25.252+0900 D/W_HOME  ( 2311): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
03-24 13:44:25.252+0900 D/APP_SVC ( 2311): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.basicui - no result
03-24 13:44:25.252+0900 D/AUL     ( 2311): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.basicui
03-24 13:44:25.252+0900 D/AUL     ( 2311): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
03-24 13:44:25.252+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(495) > __request_handler: 0
03-24 13:44:25.252+0900 D/AUL_AMD ( 2226): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.basicui
03-24 13:44:25.252+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : org.tizen.w-home
03-24 13:44:25.262+0900 E/AUL_AMD ( 2226): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
03-24 13:44:25.262+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
03-24 13:44:25.262+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1785) > process_pool: false
03-24 13:44:25.262+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
03-24 13:44:25.262+0900 D/AUL_AMD ( 2226): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.basicui
03-24 13:44:25.262+0900 D/AUL_AMD ( 2226): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
03-24 13:44:25.262+0900 D/AUL     ( 2226): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
03-24 13:44:25.262+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
03-24 13:44:25.262+0900 D/AUL_PAD ( 2234): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
03-24 13:44:25.262+0900 D/AUL_PAD ( 2234): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 9247 /opt/usr/apps/org.example.basicui/bin/basicui
03-24 13:44:25.262+0900 D/AUL_PAD ( 2234): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
03-24 13:44:25.262+0900 D/AUL_PAD ( 9247): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
03-24 13:44:25.272+0900 D/LAUNCH  ( 9247): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
03-24 13:44:25.282+0900 I/efl-extension( 9247): efl_extension.c: eext_mod_init(39) > Init
03-24 13:44:25.292+0900 W/CRASH_MANAGER( 9061): worker.c: worker_job(1189) > 1109247626173145879466
