require 'test_helper'

class DmnhomnuocsxesControllerTest < ActionController::TestCase
  setup do
    @dmnhomnuocsx = dmnhomnuocsxes(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhomnuocsxes)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhomnuocsx" do
    assert_difference('Dmnhomnuocsx.count') do
      post :create, dmnhomnuocsx: { stt: @dmnhomnuocsx.stt, ten: @dmnhomnuocsx.ten }
    end

    assert_redirected_to dmnhomnuocsx_path(assigns(:dmnhomnuocsx))
  end

  test "should show dmnhomnuocsx" do
    get :show, id: @dmnhomnuocsx
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhomnuocsx
    assert_response :success
  end

  test "should update dmnhomnuocsx" do
    patch :update, id: @dmnhomnuocsx, dmnhomnuocsx: { stt: @dmnhomnuocsx.stt, ten: @dmnhomnuocsx.ten }
    assert_redirected_to dmnhomnuocsx_path(assigns(:dmnhomnuocsx))
  end

  test "should destroy dmnhomnuocsx" do
    assert_difference('Dmnhomnuocsx.count', -1) do
      delete :destroy, id: @dmnhomnuocsx
    end

    assert_redirected_to dmnhomnuocsxes_path
  end
end
