// Copyright (c) 2014, https://github.com/rhcad/touchvg

package touchvg.demo1;

import android.graphics.Color;
import android.os.Bundle;
import android.view.ViewGroup;

public class ExampleActivitySF extends ExampleActivity1 {

    @Override
    protected void createGraphView(Bundle savedInstanceState) {
        setContentView(R.layout.activity_example1);
        final ViewGroup layout = (ViewGroup) this.findViewById(R.id.frame);
        hlp.createSurfaceView(this, layout).setBackgroundColor(Color.GRAY);

        if (savedInstanceState == null) {
            hlp.startRecord(PATH + "record");
        }
    }
}