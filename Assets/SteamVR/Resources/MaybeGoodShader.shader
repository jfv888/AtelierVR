Shader "Unlit/MaybeGoodShader"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
    }

        SubShader
    {
        Tags {"Queue" = "Transparent" "RenderType" = "Transparent"}
        LOD 100

        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldNormal;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            // Choose the green side (you can change the values to select a different side)
            float greenSide = step(0.99, IN.worldNormal.y);

            // Set the color as a mix between yellow and green based on the greenSide value
            o.Albedo = lerp(float3(1, 1, 0), float3(0, 1, 0), greenSide);
        }
        ENDCG
    }
        FallBack "Diffuse"
}
